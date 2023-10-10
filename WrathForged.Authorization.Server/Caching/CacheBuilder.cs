// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Common.Caching;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Caching
{
    public class CacheBuilder(ClassFactory classFactory, IConfiguration configuration, ForgeCache forgeCache)
    {
        private readonly ClassFactory _classFactory = classFactory;
        private readonly IConfiguration _configuration = configuration;
        private readonly ForgeCache _forgeCache = forgeCache;

        public void Build()
        {
            var cacheUpdate = TimeSpan.FromSeconds(_configuration.GetDefaultValue("RealmStatusUpdateTime_Seconds", 120));
            _forgeCache.Set(AuthCacheKeys.REALM_LISTS, cacheUpdate, () =>
            {
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();
                return authDatabase.Realmlists.ToDictionary(d => d.Id, d => d);
            });

            _forgeCache.Set(AuthCacheKeys.BUILD_INFOS, cacheUpdate, () =>
            {
                using var buildInfoContext = _classFactory.Resolve<AuthDatabase>();
                return buildInfoContext.BuildInfos.ToDictionary(d => d.Build, d => d);
            });

            _forgeCache.Set(AuthCacheKeys.ACCOUNT_BANS, cacheUpdate, () =>
            {
                using var bannedAccountsContext = _classFactory.Resolve<AuthDatabase>();
                return bannedAccountsContext.AccountBanneds.ToDictionary(d => d.Id, d => d).Where(b => b.Value.Active || b.Value.Unbandate.FromUnixTime() < DateTime.UtcNow).ToDictionary(d => d.Key, d => d.Value);
            });

            _forgeCache.Set(AuthCacheKeys.IP_BANS, cacheUpdate, () =>
            {
                using var bannedIpsContext = _classFactory.Resolve<AuthDatabase>();
                return bannedIpsContext.IpBanneds.ToDictionary(d => d.Ip, d => d).Where(kvp => CheckBanDate(kvp.Value)).ToDictionary(d => d.Key, d => d.Value);
            });
        }

        private static bool CheckBanDate(IpBanned b) => b.Bandate == 0 || (b.Unbandate != 0 && b.Unbandate != 0 && b.Unbandate.FromUnixTime() < DateTime.UtcNow);
    }
}