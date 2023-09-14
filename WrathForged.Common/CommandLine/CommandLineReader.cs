// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using Serilog;

namespace WrathForged.Common.CommandLine
{
    public class CommandLineReader
    {
        private readonly ProgramExitNotifier _programExitNotifier;
        private readonly ILogger _logger;
        private readonly ClassFactory _classFactory;

        public CommandLineReader(ProgramExitNotifier programExitNotifier, ILogger logger, ClassFactory classFactory)
        {
            _programExitNotifier = programExitNotifier;
            _logger = logger;
            _classFactory = classFactory;
        }

        public async void ReadCommandLineUntilProgramExit()
        {
            var commandLineArgumentHandlers = _classFactory.ResolveAll<ICommandLineArgumentHandler>().ToList();

            var rootCommand = new RootCommand();

            foreach (var commandLineArgumentHandler in commandLineArgumentHandlers)
            {
                rootCommand.AddCommand(commandLineArgumentHandler.AddCommand());
            }

            while (!_programExitNotifier.IsExiting)
            {
                var commandLine = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(commandLine))
                    continue;

                var args = commandLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var code = await rootCommand.InvokeAsync(args);

                if (code != 0)
                    _logger.Error("Command exited with code {Code}", code);
            }
        }
    }
}