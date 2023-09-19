// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using WrathForged.Common.CommandLine;

namespace WrathForged.Common.DBC.Commands
{
    public class DBCExportCommand : ICommandLineArgumentHandler
    {
        public Command AddCommand()
        {
            var command = new Command("--dbcExport", "Exports the SQL DBC database to DBC files.");
            var dbcs = new Argument<string>("dbcNames", "")
            {
                Arity = ArgumentArity.ZeroOrOne
            };
            command.AddArgument(dbcs);
            command.SetHandler((reason) =>
            {
            }, dbcs);

            return command;
        }
    }
}