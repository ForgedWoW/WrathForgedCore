// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;

namespace WrathForged.Common.Threading;

public class BackgroundWorkProcessor
{
    private readonly List<ScheduledAction> _scheduledActions = [];
    private readonly SemaphoreSlim _semaphore;
    private readonly ILogger _logger;
    private readonly ProgramExitNotifier _programExitNotifier;
    private readonly List<ScheduledAction> _actionsToExecute = [];
    private readonly List<ScheduledAction> _actionsToRemove = [];
    private readonly AutoResetEvent _queueSemaphore = new AutoResetEvent(false);

    public BackgroundWorkProcessor(ILogger logger, ProgramExitNotifier programExitNotifier, IConfiguration configuration)
    {
        var maxConcurrentTasks = configuration.GetDefaultValue("BackgroundWorkProcessor:ThreadCount", 10);
        _semaphore = new SemaphoreSlim(maxConcurrentTasks, maxConcurrentTasks);
        _logger = logger;
        _programExitNotifier = programExitNotifier;
        programExitNotifier.ExitProgram += (sender, args) =>
        {
            lock (_scheduledActions)
            {
                _scheduledActions.Clear();
                _semaphore.Dispose();
            }
        };

        Task.Run(() =>
        {
            while (!_programExitNotifier.IsExiting)
            {
                 _queueSemaphore.WaitOne(1000); // the semaphore could have been set. If it was, we don't want to wait a full second
                CheckScheduledActions();
            }
        });
    }

    /// <summary>
    ///     Add work to be done in the background. This will be executed on a background thread. Work is evaluated in the order it is added. Work is checked every second. Work is not guaranteed to be executed at the exact time specified.
    ///     <para>Use <see cref="Task.ContinueWith(Action{Task, object?}, object?)"/> to execute code after the work is done.</para>
    ///     <code>
    ///     var task = new Task(() => { some code.. });
    ///     // OR
    ///     var task = new Task(() => someMethod);
    ///     
    ///     task.ContinueWith((task, state) => { some code.. }, null);
    ///     </code>
    /// </summary>
    /// <param name="action">The action of the work</param>
    /// <param name="wait">How long to wait before executing the work, <see langword="default"/> will execute at the next check for work.</param>
    /// <param name="interval">How often to trigger the work, <see langword="default"/> will not repeat.</param>
    public void Add(Task action, TimeSpan wait = default, TimeSpan interval = default)
    {
        lock (_scheduledActions)
        {
            _scheduledActions.Add(new ScheduledAction
            {
                Action = action,
                NextExecutionTime = DateTime.UtcNow.Add(wait),
                Interval = interval,
            });
        }
    }

    /// <summary>
    ///     Add work to be done in the background. This will be executed on a background thread. Work is evaluated in the order it is added. Work is checked every second. Work is not guaranteed to be executed at the exact time specified.
    /// </summary>
    /// <param name="action">The action of the work</param>
    /// <param name="wait">How long to wait before executing the work, <see langword="default"/> will execute at the next check for work.</param>
    /// <param name="interval">How often to trigger the work, <see langword="default"/> will not repeat.</param>
    public void Add(Action action, TimeSpan wait = default, TimeSpan interval = default) => Add(new Task(action), wait, interval);


    /// <summary>
    ///     Checks all scheduled actions and executes them if they are ready to be executed.
    ///     <br> Executes the actions that are ready.</br>
    ///     <br> This happens on a background thread. This call returns immediately.</br>
    /// </summary>
    public void ExecuteNow()
    {
        _queueSemaphore.Set();
    }

    private void CheckScheduledActions()
    {
        lock (_scheduledActions)
        {
            var now = DateTime.UtcNow;
            foreach (var scheduledAction in _scheduledActions)
            {
                if (_programExitNotifier.IsExiting)
                    return;

                if (now >= scheduledAction.NextExecutionTime)
                {
                    _actionsToExecute.Add(scheduledAction);

                    if (scheduledAction.Interval != default)
                    {
                        _actionsToRemove.Add(scheduledAction);
                    }
                    else
                    {
                        scheduledAction.NextExecutionTime = now.Add(scheduledAction.Interval);
                    }
                }
            }

            foreach (var actionToRemove in _actionsToRemove)
                _ = _scheduledActions.Remove(actionToRemove);
        }

        foreach (var actionToExecute in _actionsToExecute)
        {
            _semaphore.Wait();

            if (_programExitNotifier.IsExiting)
                return;

            actionToExecute.Action.ContinueWith(task =>
            {
                _semaphore.Release();
                if (task.Exception != null)
                    _logger.Error(task.Exception, "Error executing background work");
            });
            actionToExecute.Action.Start();
        }

        _actionsToExecute.Clear();
        _actionsToRemove.Clear();
    }

#pragma warning disable CS8618

    private class ScheduledAction
    {
        public Task Action { get; set; }
        public DateTime NextExecutionTime { get; set; }
        public TimeSpan Interval { get; set; }
    }
}