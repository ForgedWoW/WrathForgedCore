// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Caching
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
            var cacheUpdate = TimeSpan.FromSeconds(_configuration.GetDefaultValue("RealmStatusUpdate", 20));
            _forgeCache.Set(AuthCacheKeys.REALM_LISTS, cacheUpdate, () => _authDatabase.Realmlists.ToDictionary(d => d.Id, d => d));
            _forgeCache.Set(AuthCacheKeys.BUILD_INFOS, cacheUpdate, () => _authDatabase.BuildInfos.ToDictionary(d => d.Build, d => d));
            _forgeCache.Set(AuthCacheKeys.ACCOUNT_BANS, cacheUpdate, () => _authDatabase.AccountBanneds.Where(b => b.Active == 1).ToDictionary(d => d.Id, d => d));
            _forgeCache.Set(AuthCacheKeys.IP_BANS, cacheUpdate, () => _authDatabase.IpBanneds.Where(b => CheckBanDate(b)).ToDictionary(d => d.Ip, d => d));
        }

        private static bool CheckBanDate(IpBanned b) => b.Bandate == 0 || b.Unbandate != 0 && b.Unbandate != 0 && b.Unbandate.FromUnixTime() < DateTime.UtcNow;
    }
}