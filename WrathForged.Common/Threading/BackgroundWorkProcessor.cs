// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;

namespace WrathForged.Common.Threading
{
    public class BackgroundWorkProcessor
    {
        private readonly List<ScheduledAction> _scheduledActions = new();
        private readonly Timer _timer;
        private readonly SemaphoreSlim _semaphore;
        private readonly ILogger _logger;

        public BackgroundWorkProcessor(ILogger logger, ProgramExitNotifier programExitNotifier, IConfiguration configuration)
        {
            var maxConcurrentTasks = configuration.GetDefaultValue("BackgroundWorkProcessor:ThreadCount", 10);
            _semaphore = new SemaphoreSlim(maxConcurrentTasks, maxConcurrentTasks);
            _timer = new Timer(CheckScheduledActions, null, 0, 1000); // Adjust the interval as necessary
            _logger = logger;
            programExitNotifier.ExitProgram += (sender, args) =>
            {
                lock (_scheduledActions)
                {
                    _scheduledActions.Clear();
                    _timer.Dispose();
                    _semaphore.Dispose();
                }
            };
        }

        /// <summary>
        ///     Add work to be done in the background. This will be executed on a background thread. Work is evaluated in the order it is added. Work is checked every second. Work is not guaranteed to be executed at the exact time specified.
        /// </summary>
        /// <param name="action">The action of the work</param>
        /// <param name="interval">How often to trigger the work</param>
        /// <param name="repeat">When <see langword="true"/> repeats at the <paramref name="interval"/> forever.</param>
        public void Add(Action action, TimeSpan interval, bool repeat = true)
        {
            lock (_scheduledActions)
            {
                _scheduledActions.Add(new ScheduledAction
                {
                    Action = action,
                    NextExecutionTime = DateTime.UtcNow.Add(interval),
                    Interval = interval,
                    Repeat = repeat
                });
            }
        }

        private void CheckScheduledActions(object? state)
        {
            var actionsToExecute = new List<ScheduledAction>();
            var actionsToRemove = new List<ScheduledAction>();

            lock (_scheduledActions)
            {
                var now = DateTime.UtcNow;
                foreach (var scheduledAction in _scheduledActions)
                {
                    if (now >= scheduledAction.NextExecutionTime)
                    {
                        actionsToExecute.Add(scheduledAction);

                        if (!scheduledAction.Repeat)
                        {
                            actionsToRemove.Add(scheduledAction);
                        }
                        else
                        {
                            scheduledAction.NextExecutionTime = now.Add(scheduledAction.Interval);
                        }
                    }
                }

                foreach (var actionToRemove in actionsToRemove)
                {
                    _ = _scheduledActions.Remove(actionToRemove);
                }
            }

            foreach (var actionToExecute in actionsToExecute)
            {
                _semaphore.Wait();
                _ = Task.Run(() => ExecuteAction(actionToExecute.Action));
            }
        }

        private void ExecuteAction(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error executing background action");
            }
            finally
            {
                _ = _semaphore.Release();
            }
        }

#pragma warning disable CS8618

        private class ScheduledAction
        {
            public Action Action { get; set; }
            public DateTime NextExecutionTime { get; set; }
            public TimeSpan Interval { get; set; }
            public bool Repeat { get; set; }
        }
    }
}