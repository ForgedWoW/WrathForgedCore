// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.CommandLine;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Scripting;
using WrathForged.Database.DBC;
using WrathForged.Database.Models.DBC;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.DBC.Commands;

public class DBCExportCommand : ICommandLineArgumentHandler
{
    private readonly DBCSerializer _dbcSerializer;
    private readonly DBCDatabase _dbcDatabase;
    private readonly ILogger _logger;
    private readonly List<string> _dbcDefs = new();
    private readonly Dictionary<string, PropertyInfo> _dbSets = new(StringComparer.InvariantCultureIgnoreCase);

    public DBCExportCommand(DBCSerializer dbcSerializer, DBCDatabase dbcDatabase, ScriptLoader scriptLoader, ILogger logger)
    {
        _dbcSerializer = dbcSerializer;
        _dbcDatabase = dbcDatabase;
        _logger = logger;
        foreach (var record in scriptLoader.GetAllTypesThatUseInterface<IDBCRecord>())
        {
            var att = record.GetCustomAttributes(typeof(DBCBoundAttribute), true).FirstOrDefault();

            if (att == null)
                continue;

            _dbcDefs.Add(((DBCBoundAttribute)att).Name);
        }

        var dbcSets = typeof(DBCDatabase).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        foreach (var prop in dbcSets)
        {
            if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
            {
                var type = prop.PropertyType.GetGenericArguments()[0];
                var att = type.GetCustomAttributes(typeof(DBCBoundAttribute), true).FirstOrDefault();

                if (att == null)
                    continue;

                var at = (DBCBoundAttribute)att;
                _dbSets[at.Name] = prop;
            }
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
            try
            {
                if (string.IsNullOrEmpty(outputDir))
                    outputDir = ".\\dbc\\";

                outputDir = outputDir.Replace("\"", string.Empty);

                if (!Directory.Exists(outputDir))
                    _ = Directory.CreateDirectory(outputDir);

                if (!string.IsNullOrWhiteSpace(names))
                    Export(names.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries), outputDir);
                else
                    Export(_dbcDefs, outputDir);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to export DBC's");
            }
        }, outputPath, dbcs);

        return command;
    }

    private void Export(IEnumerable<string> names, string outputDir)
    {
        _logger.Information("Exporting {NamesCount} DBC's to {OutputDir}", names.Count(), outputDir);
        var startTime = DateTime.UtcNow;
        foreach (var name in names)
        {
            _logger.Information("Exporting DBC {Name}", name);
            try
            {
                if (_dbSets.TryGetValue(name, out var propertyInfo))
                {
                    var propVal = propertyInfo.GetValue(_dbcDatabase);

                    if (propVal != null)
                    {
                        var now = DateTime.UtcNow;
                        _dbcSerializer.Serialize((IEnumerable<IDBCRecord>)propVal, outputDir, propertyInfo);
                        _logger.Information("Export of {Name}: Successful in {Time}", name, (DateTime.UtcNow - now).ToReadableString());
                    }
                    else
                    {
                        _logger.Warning("Export of {Name}: Unsuccessful", name);
                    }
                }
                else
                {
                    _logger.Warning("Could not find DBC {Name}", name);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to export DBC {Name}", name);
            }
        }

        _logger.Information("Exporting DBC's completed in {Time}", (DateTime.UtcNow - startTime).ToReadableString());
    }
}