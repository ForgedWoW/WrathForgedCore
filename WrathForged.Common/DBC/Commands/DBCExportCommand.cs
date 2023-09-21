// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Scripting;
using WrathForged.Database.DBC;
using WrathForged.Database.Models.DBC;

namespace WrathForged.Common.DBC.Commands
{
    public class DBCExportCommand : ICommandLineArgumentHandler
    {
        private readonly DBCSerializer _dbcSerializer;
        private readonly DBCDatabase _dbcDatabase;
        private readonly List<string> _dbcDefs = new();

        public DBCExportCommand(DBCSerializer dbcSerializer, DBCDatabase dbcDatabase, ScriptLoader scriptLoader)
        {
            _dbcSerializer = dbcSerializer;
            _dbcDatabase = dbcDatabase;
            foreach (var record in scriptLoader.GetAllTypesThatUseInterface<IDBCRecord>())
            {
                var att = record.GetCustomAttributes(typeof(DBCBoundAttribute), true).FirstOrDefault();

                if (att == null)
                    continue;

                _dbcDefs.Add(((DBCBoundAttribute)att).Name);
            }
        }

        public Command AddCommand()
        {
            var command = new Command("--dbcExport", "Exports the SQL DBC database to DBC files.");
            var outputPath = new Argument<string>("outputPath", "if provided, it will be the output directory given. If none is used they will be added to .\\dbc\\")
            {
                Arity = ArgumentArity.ZeroOrOne
            };
            var dbcs = new Argument<string>("dbcNames", "If provided, you can give a comma delimited list of dbc names to export specific DBC's. Ex: Achievement.dbc,Achievement_Category.dbc")
            {
                Arity = ArgumentArity.ZeroOrOne
            };
            command.AddArgument(outputPath);
            command.AddArgument(dbcs);
            command.SetHandler((outputDir, names) =>
            {
                if (string.IsNullOrEmpty(outputDir))
                    outputDir = ".\\dbc\\";

                if (!Directory.Exists(outputDir))
                    _ = Directory.CreateDirectory(outputDir);

                if (!string.IsNullOrWhiteSpace(names))
                    Export(names.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries), outputDir);
                else
                    Export(_dbcDefs, outputDir);
            }, outputPath, dbcs);

            return command;
        }

        Command ICommandLineArgumentHandler.AddCommand() => throw new NotImplementedException();

        private void Export(IEnumerable<string> names, string outputDir)
        {
            foreach (var name in names)
            {
                switch (name.ToLower())
                {
                    case "achievement.dbc":
                        _dbcSerializer.Serialize(_dbcDatabase.Achievements, outputDir);
                        break;

                    case "achievement_category.dbc":
                        _dbcSerializer.Serialize(_dbcDatabase.AchievementCategories, outputDir);
                        break;
                }
            }
        }
    }
}