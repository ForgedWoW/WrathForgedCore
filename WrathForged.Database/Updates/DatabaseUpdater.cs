// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Database.Models;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.DBC;
using WrathForged.Database.Models.World;
using WrathForged.Serialization.Models;

namespace WrathForged.Database.Updates
{
    public class DatabaseUpdater(WorldDatabase worldDatabase, CharacterDatabase characterDatabase, AuthDatabase authDatabase, DBCDatabase dBCDatabase,
                            IConfiguration configuration, ILogger logger)
    {
        internal struct SQLUpdates
        {
            internal List<Update> Updates { get; set; }
            internal List<UpdatesInclude> UpdatesIncludes { get; set; }
        }

        public const string WORLD_DATABASE = "world";
        public const string CHARACTER_DATABASE = "characters";
        public const string AUTH_DATABASE = "auth";
        public const string DBC_DATABASE = "dbc";
        private readonly WorldDatabase _worldDatabase = worldDatabase;
        private readonly CharacterDatabase _characterDatabase = characterDatabase;
        private readonly AuthDatabase _authDatabase = authDatabase;
        private readonly DBCDatabase _dBCDatabase = dBCDatabase;
        private readonly IConfiguration _configuration = configuration;
        private readonly ILogger _logger = logger;

        public void Update()
        {
            var startTime = DateTime.UtcNow;
            if (IsDatabaseConnected(_worldDatabase))
                UpdateWorld();

            if (IsDatabaseConnected(_characterDatabase))
                UpdateCharacters();

            if (IsDatabaseConnected(_authDatabase))
                UpdateAuth();

            if (IsDatabaseConnected(_dBCDatabase))
                UpdateDBC();

            _logger.Information("Database updates completed in {0}.", (DateTime.UtcNow - startTime).ToReadableString());
        }

        private bool IsDatabaseConnected(DbContext context)
        {
            var startTime = DateTime.UtcNow;
            _logger.Information("Checking if {0} database is connected.", context.Database.GetDbConnection().Database);
            try
            {
                context.Database.GetDbConnection().Open();
                _logger.Information("{0} database is connected in {1}.", context.Database.GetDbConnection().Database, (DateTime.UtcNow - startTime).ToReadableString());
                return true;
            }
            catch
            {
                _logger.Warning("{0} database is not connected in {1}.", context.Database.GetDbConnection().Database, (DateTime.UtcNow - startTime).ToReadableString());
                return false;
            }
        }

        private void UpdateWorld()
        {
            var startTime = DateTime.UtcNow;
            var updates = new SQLUpdates()
            {
                Updates = [.. _worldDatabase.Updates],
                UpdatesIncludes = [.. _worldDatabase.UpdatesIncludes]
            };

            updates = Update(updates, WORLD_DATABASE, _worldDatabase);

            if (updates.Updates != null)
                _worldDatabase.Updates.AddRange(updates.Updates);

            if (updates.UpdatesIncludes != null)
                _worldDatabase.UpdatesIncludes.AddRange(updates.UpdatesIncludes);

            if (updates.Updates != null || updates.UpdatesIncludes != null)
                _ = _worldDatabase.SaveChanges();

            _logger.Information("World updates completed in {0}.", (DateTime.UtcNow - startTime).ToReadableString());
        }

        private void UpdateCharacters()
        {
            var startTime = DateTime.UtcNow;
            var updates = new SQLUpdates()
            {
                Updates = [.. _characterDatabase.Updates],
                UpdatesIncludes = [.. _characterDatabase.UpdatesIncludes]
            };

            updates = Update(updates, CHARACTER_DATABASE, _characterDatabase);

            if (updates.Updates != null)
                _characterDatabase.Updates.AddRange(updates.Updates);

            if (updates.UpdatesIncludes != null)
                _characterDatabase.UpdatesIncludes.AddRange(updates.UpdatesIncludes);

            if (updates.Updates != null || updates.UpdatesIncludes != null)
                _ = _characterDatabase.SaveChanges();

            _logger.Information("Character updates completed in {0}.", (DateTime.UtcNow - startTime).ToReadableString());
        }

        private void UpdateAuth()
        {
            var startTime = DateTime.UtcNow;
            var updates = new SQLUpdates()
            {
                Updates = [.. _authDatabase.Updates],
                UpdatesIncludes = [.. _authDatabase.UpdatesIncludes]
            };

            updates = Update(updates, AUTH_DATABASE, _authDatabase);

            if (updates.Updates != null)
                _authDatabase.Updates.AddRange(updates.Updates);

            if (updates.UpdatesIncludes != null)
                _authDatabase.UpdatesIncludes.AddRange(updates.UpdatesIncludes);

            if (updates.Updates != null || updates.UpdatesIncludes != null)
                _ = _authDatabase.SaveChanges();

            _logger.Information("Auth updates completed in {0}.", (DateTime.UtcNow - startTime).ToReadableString());
        }

        private void UpdateDBC()
        {
            var startTime = DateTime.UtcNow;
            var updates = new SQLUpdates()
            {
                Updates = [.. _dBCDatabase.Updates],
                UpdatesIncludes = [.. _dBCDatabase.UpdatesIncludes]
            };

            updates = Update(updates, DBC_DATABASE, _dBCDatabase);

            if (updates.Updates != null)
                _dBCDatabase.Updates.AddRange(updates.Updates);

            if (updates.UpdatesIncludes != null)
                _dBCDatabase.UpdatesIncludes.AddRange(updates.UpdatesIncludes);

            if (updates.Updates != null || updates.UpdatesIncludes != null)
                _ = _dBCDatabase.SaveChanges();

            _logger.Information("DBC updates completed in {0}.", (DateTime.UtcNow - startTime).ToReadableString());
        }

        private SQLUpdates Update(SQLUpdates updates, string dbName, DbContext dbContext)
        {
            var updatePath = GetDefaultValue(_configuration, "Database:SQLDir", ".\\sql");
            var path = Path.Combine(updatePath, "updates", dbName);

            if (!Directory.Exists(path))
                return new SQLUpdates();

            var sqlToRun = Directory.GetFiles(path, $"*.sql", SearchOption.AllDirectories).Select(p => new FileInfo(p)).ToList();

            var newUpdates = new SQLUpdates();

            if (sqlToRun == null || sqlToRun.Count == 0)
                return newUpdates;

            var indexByHash = updates.Updates.Where(u => u.Hash != null).Select(u => u.Hash).ToHashSet();

            _logger.Information("Checking {0} SQL updates for {1} database.", sqlToRun.Count, dbName);
            var startTime = DateTime.UtcNow;
            foreach (var sql in sqlToRun)
            {
                if (sql.Name == "void.sql")
                    continue;

                var hash = CalculateHash(sql.FullName);

                if (indexByHash.Contains(hash)) // Already applied
                    continue;

                // check if the path the file is in is archived
                var archived = false;

                foreach (var f in updates.UpdatesIncludes)
                {
                    if (sql.DirectoryName?.Contains(f.Path.Replace("$", ""), StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        if (f.State == "RELEASED")
                            continue;

                        archived = true; // if its not released, its archived. This will skip this file.
                    }
                }

                if (archived)
                    continue;

                _logger.Information("Running SQL update: {0}", sql.Name);
                try
                {
                    var updateStart = DateTime.UtcNow;
                    _ = dbContext.Database.ExecuteSqlRaw(File.ReadAllText(sql.FullName));
                    var elapsed = DateTime.UtcNow - updateStart;
                    _logger.Information("SQL update {0} took {1}.", sql.Name, elapsed.ToReadableString());

                    newUpdates.Updates ??= new List<Update>();

                    newUpdates.Updates.Add(new Update()
                    {
                        Name = sql.Name,
                        Hash = hash,
                        State = "RELEASED",
                        Speed = (uint)elapsed.TotalMilliseconds,
                        Timestamp = DateTime.UtcNow
                    });
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "Error running SQL update: {0}", sql);
                }
            }

            _logger.Information("Ran {0} SQL updates for {1} database in {2}.", newUpdates.Updates == null ? 0 : newUpdates.Updates.Count, dbName, (DateTime.UtcNow - startTime).ToReadableString());

            return newUpdates;
        }

        private static T GetDefaultValue<T>(IConfiguration config, string key, T defaultValue)
        {
            var value = config[key];

            if (value == null)
                return defaultValue;

            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }

        private static string CalculateHash(string fileName)
        {
            var text = File.ReadAllText(fileName).Replace("\r", "");

            return SHA1.HashData(Encoding.UTF8.GetBytes(text)).ToHexString();
        }
    }
}