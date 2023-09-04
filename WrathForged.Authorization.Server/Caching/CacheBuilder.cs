﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Caching
{
    public class CacheBuilder
    {
        private readonly ClassFactory _classFactory;
        private readonly IConfiguration _configuration;
        private readonly ForgeCache _forgeCache;

        public CacheBuilder(ClassFactory classFactory, IConfiguration configuration, ForgeCache forgeCache)
        {
            _classFactory = classFactory;
            _configuration = configuration;
            _forgeCache = forgeCache;
        }

        public void Build()
        {
            var cacheUpdate = TimeSpan.FromSeconds(_configuration.GetDefaultValue("RealmStatusUpdate", 20));
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
                return bannedAccountsContext.AccountBanneds.Where(b => b.Active == 1).ToDictionary(d => d.Id, d => d);
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