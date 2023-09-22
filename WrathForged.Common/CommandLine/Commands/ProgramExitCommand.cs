// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.CommandLine;
using WrathForged.Common.Localization;

namespace WrathForged.Common.CommandLine.Commands
{
    public class ProgramExitCommand : ICommandLineArgumentHandler
    {
        private readonly ProgramExitNotifier _programExitNotifier;
        private readonly Localizer _localizer;

        public ProgramExitCommand(ProgramExitNotifier programExitNotifier, Localizer localizer)
        {
            _programExitNotifier = programExitNotifier;
            _localizer = localizer;
        }

        public Command AddCommand()
        {
            var command = new Command("--exit", "Exits the program.");
            command.AddAlias("--quit");
            command.AddAlias("--stop");
            var timeArg = new Argument<int>("time", "the number of seconds to start the shutdown in, this is optional")
            {
                Arity = ArgumentArity.ZeroOrOne
            };
            var reasonArg = new Argument<string>("reason", "the reason for the shutdown, this is optional")
            {
                Arity = ArgumentArity.ZeroOrOne
            };
            command.AddArgument(timeArg);
            command.AddArgument(reasonArg);
            command.SetHandler((time, reason) =>
            {
                if (time != 0)
                    _programExitNotifier.NotifyStopDelayed(time, reason ?? "Exit program called.");
                else
                    _programExitNotifier.NotifyStop(reason ?? "Exit program called.");
            }, timeArg, reasonArg);

            return command;
        }
    }
}