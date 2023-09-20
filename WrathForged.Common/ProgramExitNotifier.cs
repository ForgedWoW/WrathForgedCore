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

        public bool DelayedStopRequested => _timer != null;
        public bool IsExiting { get; private set; }

        public event EventHandler<int> ExitingInSeconds;

        public event EventHandler ExitProgram;

        /// <summary>
        ///     The Logger and common services are stopped here. DO not attempt to use them.
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