// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Database;

#pragma warning disable CS8618

namespace WrathForged.Common
{
    public class ProgramExitNotifier
    {
        private const int TIMER_STOPPED = -1;
        private Task? _timer;
        private int _secondsTilStop = TIMER_STOPPED;
        private readonly ILogger _logger;
        private readonly ClassFactory _classFactory;
        private readonly CancellationTokenSource _cancelationTokenSource = new(); // Global cancellation token source for stopping the server.

        public ProgramExitNotifier(ILogger logger, ClassFactory classFactory)
        {
            _logger = logger;
            _classFactory = classFactory;
        }

        /// <summary>
        ///     <see langword="true"/> if a delayed stop is requested, <see langword="false"/> otherwise.
        /// </summary>
        public bool DelayedStopRequested => _timer != null;

        /// <summary>
        ///     Set to <see langword="true"/> when the server is starting the exit process. This is set before any exit events are called and before any cancellation tokens are cancelled.
        /// </summary>
        public bool IsExiting { get; private set; }

        /// <summary>
        ///     Called when the server is exiting in X seconds. This is called once, when the timer is started.
        /// </summary>
        public event EventHandler<int> ExitingInSeconds;

        /// <summary>
        ///     Called on program exit. Logger and common services are still available.
        /// </summary>
        public event EventHandler ExitProgram;

        /// <summary>
        ///     The Logger and common services are stopped here. DO NOT attempt to use them. Database is still available.
        /// </summary>
        public event EventHandler ExitProgramLate;

        public CancellationToken GetCancellationToken() => _cancelationTokenSource.Token;

        public void NotifyStopDelayed(int secondsTilStop, string stopReason)
        {
            if (secondsTilStop == 0)
            {
                NotifyStop(stopReason);
                return;
            }

            if (DelayedStopRequested)
            {
                _logger.Information("Server Delayed Stop requested already in process with {0} seconds left.", _secondsTilStop);
                return;
            }

            _secondsTilStop = secondsTilStop;
            _logger.Information("Server Delayed Stop requested in {0} seconds.", secondsTilStop);
            ExitingInSeconds?.Invoke(this, _secondsTilStop);

            _timer = Task.Run(async () =>
            {
                while (_secondsTilStop > 0)
                {
                    await Task.Delay(1000);
                    _secondsTilStop--;
                }

                if (_secondsTilStop > TIMER_STOPPED)
                    NotifyStop(stopReason);
            });
        }

        public void NotifyStop(string stopReason)
        {
            _logger.Information("Server Stop requested.");
            _logger.Information("Reason: {0}", stopReason);
            IsExiting = true;
            _cancelationTokenSource.Cancel();

            ExitProgram?.Invoke(this, EventArgs.Empty);
            ExitProgramLate?.Invoke(this, EventArgs.Empty);
            _classFactory.Container.ShutdownDatabase();
            _logger.Information("Server Stop completed.");
            Environment.Exit(0);
        }

        public void CancelDelayedStop()
        {
            if (!DelayedStopRequested)
                return;

            _secondsTilStop = TIMER_STOPPED;
            _timer?.Dispose();
            _timer = null;
            _logger.Information("Server Delayed Stop cancelled.");
        }
    }
}