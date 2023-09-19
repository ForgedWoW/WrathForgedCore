// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.DBC;
using WrathForged.Database.Models.World;

namespace WrathForged.Database.Updates
{
    public class DatabaseUpdater
    {
        private readonly WorldDatabase _worldDatabase;
        private readonly CharacterDatabase _characterDatabase;
        private readonly AuthDatabase _authDatabase;
        private readonly DBCDatabase _dBCDatabase;

        public DatabaseUpdater(WorldDatabase worldDatabase, CharacterDatabase characterDatabase, AuthDatabase authDatabase, DBCDatabase dBCDatabase)
        {
            _worldDatabase = worldDatabase;
            _characterDatabase = characterDatabase;
            _authDatabase = authDatabase;
            _dBCDatabase = dBCDatabase;
        }


        public void Update()
        {
            if (IsDatabaseConnected(_worldDatabase))
                UpdateWorld();

            if (IsDatabaseConnected(_characterDatabase))
                UpdateCharacters();

            if (IsDatabaseConnected(_authDatabase))
                UpdateAuth();

            if (IsDatabaseConnected(_dBCDatabase))
                UpdateDBC();
        }

        private bool IsDatabaseConnected(DbContext context)
        {
            try
            {
                context.Database.GetDbConnection().Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void UpdateWorld()
        {

        }

        private void UpdateCharacters()
        {

        }

        private void UpdateAuth()
        {

        }

        private void UpdateDBC()
        {

        }
    }
}