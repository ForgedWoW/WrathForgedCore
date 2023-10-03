// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Util.ConvertConfigValue;

namespace WrathForged.Common.CommandLine;

public class CommandLineReader(ProgramExitNotifier programExitNotifier, ILogger logger, ClassFactory classFactory, IConfiguration configuration)
{
    private readonly ProgramExitNotifier _programExitNotifier = programExitNotifier;
    private readonly ILogger _logger = logger;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly IConfiguration _configuration = configuration;

    public async void ReadCommandLineUntilProgramExit()
    {
        var commandLineArgumentHandlers = _classFactory.ResolveAll<ICommandLineArgumentHandler>().ToList();

        var rootCommand = new RootCommand();

        foreach (var commandLineArgumentHandler in commandLineArgumentHandlers)
        {
            rootCommand.AddCommand(commandLineArgumentHandler.AddCommand());
        }

        Console.ForegroundColor = _configuration.GetDefaultValueWithConverter<WrathEnumConverter, ConsoleColor>("Console:HighlightColor", ConsoleColor.DarkRed);

        if (_configuration.GetDefaultValueWithConverter<BoolConverter, bool>("Console:BeepOnStartup", true))
            Console.Beep();

        while (!_programExitNotifier.IsExiting)
        {
            Console.ForegroundColor = _configuration.GetDefaultValueWithConverter<WrathEnumConverter, ConsoleColor>("Console:HighlightColor", ConsoleColor.DarkRed);
            Console.Write("> ");
            Console.ForegroundColor = _configuration.GetDefaultValueWithConverter<WrathEnumConverter, ConsoleColor>("Console:DefaultColor", ConsoleColor.White);
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