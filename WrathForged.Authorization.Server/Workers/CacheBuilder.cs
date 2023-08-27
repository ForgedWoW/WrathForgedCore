// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Workers
{
    public class CacheBuilder
    {
        private readonly AuthDatabase _authDatabase;
        private readonly IConfiguration _configuration;
        private readonly ForgeCache _forgeCache;

        public CacheBuilder(AuthDatabase authDatabase, IConfiguration configuration, ForgeCache forgeCache)
        {
            _authDatabase = authDatabase;
            _configuration = configuration;
            _forgeCache = forgeCache;
        }

        public void Build()
        {
            _forgeCache.Set(TimeSpan.FromSeconds(_configuration.GetDefaultValue("RealmStatusUpdate", 20)), () => _authDatabase.Realmlists.ToDictionary(d => d.Id, d => d));
            _forgeCache.Set(TimeSpan.FromSeconds(_configuration.GetDefaultValue("RealmStatusUpdate", 20)), () => _authDatabase.BuildInfos.ToDictionary(d => d.Build, d => d));
        }
    }
}