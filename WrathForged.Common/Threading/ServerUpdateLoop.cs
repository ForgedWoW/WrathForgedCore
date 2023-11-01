// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Scripting;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Common.Time;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Threading;

public class ServerUpdateLoop(IConfiguration configuration, ProgramExitNotifier programExitNotifier, ClassFactory classFactory, ILogger logger)
{
    private readonly ProgramExitNotifier _programExitNotifier = programExitNotifier;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ILogger _logger = logger;
    private bool _started;
    private readonly uint _minTickTime = configuration.GetDefaultValue("ServerUpdateLoop:MinTickTimeMilliseconds", 1u);
    private readonly int _maxStuckTime = configuration.GetDefaultValue("ServerUpdateLoop:MaxCoreStuckTimeSeconds", 60);
    private double _lastTickTime = 0;
    private DateTime _lastTickDateTime = DateTime.UtcNow;
    private Task? _updateLoop;
    private readonly ConcurrentQueue<(IUpdateLoop loop, int priority)> _registerQueue = new();
    private readonly ConcurrentQueue<(IUpdateLoop loop, int priority)> _unRegisterQueue = new();

    public const int UPDATE_LOOP_PRIORITY_LOW = 500;
    public const int UPDATE_LOOP_PRIORITY_NORMAL = 200;
    public const int UPDATE_LOOP_PRIORITY_HIGH = 10;

    // We use HashSet to prevent duplicate updates
    private readonly SortedDictionary<int, HashSet<IUpdateLoop>> _updateMethods = [];

    public void Start()
    {
        if (!_started)
        {
            _started = true;

            foreach (var updateLoop in _classFactory.LocateAll<IUpdateLoopScript>())
                RegisterUpdateLoop(updateLoop);

            _updateLoop = Task.Run(UpdateLoop, _programExitNotifier.GetCancellationToken());
        }
    }

    /// <summary>
    ///     Adds an update loop to the update loop queue. This will be called every tick.
    ///     The core has priorities set for of its functions. There is room between updates to add your own at specific priorities.
    ///     <see cref="UpdateLoopPriorities"/> for all of the cores priorities.
    /// </summary>
    /// <param name="updateLoop"></param>
    /// <param name="priority"></param>
    public void RegisterUpdateLoop(IUpdateLoop updateLoop, int priority = UPDATE_LOOP_PRIORITY_LOW) => _registerQueue.Enqueue((updateLoop, priority));

    public void UnregisterUpdateLoop(IUpdateLoop updateLoop, int priority = UPDATE_LOOP_PRIORITY_LOW) => _unRegisterQueue.Enqueue((updateLoop, priority));

    private void MonitorUpdateLoop()
    {
        while (!_programExitNotifier.IsExiting)
        {
            var timeDiff = DateTime.UtcNow - _lastTickDateTime;

            if (timeDiff.TotalSeconds > _maxStuckTime)
            {
                _logger.Fatal("Core has been stuck for {TimeDiff}.", timeDiff.ToReadableString());
                _updateLoop?.Dispose();
                _programExitNotifier.NotifyStop($"Core has been stuck for {timeDiff.ToReadableString()}.");
            }

            Task.Delay(10000, _programExitNotifier.GetCancellationToken()).Wait();
        }
    }

    private void UpdateLoop()
    {
        _lastTickTime = TimeUtil.GetMillisecondsSinceStartup();

        while (!_programExitNotifier.IsExiting)
        {
            _lastTickDateTime = DateTime.UtcNow;
            var realTime = TimeUtil.GetMillisecondsSinceStartup();
            var startTime = DateTime.UtcNow;
            var tickDiff = realTime - _lastTickTime;

            DrainRegistrationQueue();
            DrainUnRegistrationQueue();

            foreach (var updateMethod in _updateMethods)
                foreach (var updateLoop in updateMethod.Value)
                    try
                    {
                        updateLoop.UpdateTick(tickDiff);
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, "Error in update loop {UpdateLoop}.", updateLoop.GetType().Name);
                    }

            var endTime = DateTime.UtcNow;

            var tickDelayDiff = (endTime - startTime).TotalMilliseconds;
            _lastTickTime = realTime;

            if (tickDelayDiff < _minTickTime)
                Task.Delay((int)(_minTickTime - tickDelayDiff)).Wait();
        }
    }

    private void DrainRegistrationQueue()
    {
        while (_registerQueue.TryDequeue(out var updateLoop))
        {
            if (!_updateMethods.TryGetValue(updateLoop.priority, out var updates))
            {
                updates = [];
                _updateMethods.Add(updateLoop.priority, updates);
            }

            _ = updates.Add(updateLoop.loop);
        }
    }

    private void DrainUnRegistrationQueue()
    {
        while (_unRegisterQueue.TryDequeue(out var updateLoop))
            if (_updateMethods.TryGetValue(updateLoop.priority, out var value))
                _ = value.Remove(updateLoop.loop);
    }
}
