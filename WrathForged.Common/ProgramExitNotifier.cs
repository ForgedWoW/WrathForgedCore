// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;

#pragma warning disable CS8618

namespace WrathForged.Common
{
    public class ProgramExitNotifier
    {
        private readonly ILogger _logger;
        private readonly CancellationTokenSource _cancelationTokenSource = new(); // Global cancellation token source for stopping the server.

        public ProgramExitNotifier(ILogger logger) => _logger = logger;

        public bool IsExiting { get; private set; }

        public event EventHandler ExitProgram;

        /// <summary>
        ///     The Logger and common services are stopped here. DO not attempt to use them.
        /// </summary>
        public event EventHandler ExitProgramLate;

        public CancellationToken GetCancellationToken() => _cancelationTokenSource.Token;

        public void NotifyStop()
        {
            _logger.Information("Server Stop requested.");
            IsExiting = true;
            _cancelationTokenSource.Cancel();

            ExitProgram?.Invoke(this, EventArgs.Empty);
            ExitProgramLate?.Invoke(this, EventArgs.Empty);
            _logger.Information("Server Stop completed.");
        }
    }
}