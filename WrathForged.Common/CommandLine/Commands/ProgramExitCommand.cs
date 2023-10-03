// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using WrathForged.Common.Localization;

namespace WrathForged.Common.CommandLine.Commands;

public class ProgramExitCommand(ProgramExitNotifier programExitNotifier, Localizer localizer) : ICommandLineArgumentHandler
{
    private readonly ProgramExitNotifier _programExitNotifier = programExitNotifier;
    private readonly Localizer _localizer = localizer;

    public Command AddCommand()
    {
        var command = new Command("--" + _localizer.Localize(30006), _localizer.Localize(30000));
        command.AddAlias("--" + _localizer.Localize(30007));
        command.AddAlias("--" + _localizer.Localize(30008));
        var timeArg = new Argument<int>(_localizer.Localize(30004), _localizer.Localize(30001))
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        var reasonArg = new Argument<string>(_localizer.Localize(30005), _localizer.Localize(30002))
        {
            Arity = ArgumentArity.ZeroOrOne
        };
        command.AddArgument(timeArg);
        command.AddArgument(reasonArg);
        command.SetHandler((time, reason) =>
        {
            if (time != 0)
                _programExitNotifier.NotifyStopDelayed(time, reason ?? _localizer.Localize(30003));
            else
                _programExitNotifier.NotifyStop(reason ?? _localizer.Localize(30003));
        }, timeArg, reasonArg);

        return command;
    }
}