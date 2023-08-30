// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;

namespace WrathForged.Common
{
    public class ProgramExit
    {
        private readonly ILogger _logger;
        private readonly CancellationTokenSource _cancelationTokenSource = new(); // Global cancellation token source for stopping the server.

        public ProgramExit(ILogger logger)
        {
            _logger = logger;
        }

        public bool IsExiting => _cancelationTokenSource.IsCancellationRequested;

        public event EventHandler ExitProgram;

        public CancellationToken GetCancellationToken() => _cancelationTokenSource.Token;

        public void Stop()
        {
            _logger.Information("Server Stop requested.");
            _cancelationTokenSource.Cancel();

            ExitProgram?.Invoke(this, EventArgs.Empty);
            _logger.Information("Server Stop completed.");
        }
    }
}