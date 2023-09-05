// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Common.Threading;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Validators
{
    public class BanValidator
    {
        private readonly ForgeCache _forgeCache;
        private readonly ClassFactory _classFactory;

        public BanValidator(ForgeCache forgeCache, ClassFactory classFactory, BackgroundWorkProcessor backgroundWorkProcessor)
        {
            _forgeCache = forgeCache;
            _classFactory = classFactory;
            backgroundWorkProcessor.Add(() =>
            {
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();
                foreach (var act in authDatabase.AccountBanneds.Where(a => a.Unbandate.FromUnixTime() < DateTime.UtcNow).ToList())
                {
                    act.Active = 0;
                }

                _ = authDatabase.SaveChanges();
            }, TimeSpan.FromMinutes(10));
        }

        public bool IsBanned(uint accountId, string ipAddress)
        {
            return (_forgeCache.TryGet(AuthCacheKeys.ACCOUNT_BANS, out Dictionary<uint, AccountBanned> accountBans) &&
                accountBans.TryGetValue(accountId, out var accountBan) &&
                accountBan.Active != 0) || (_forgeCache.TryGet(AuthCacheKeys.IP_BANS, out Dictionary<string, IpBanned> ipBans) &&
                ipBans.TryGetValue(ipAddress, out var ipBan) &&
                ipBan.Unbandate.FromUnixTime() > DateTime.UtcNow);
        }

        public void BanAccount(uint accountId, string banReason, string bannedBy, DateTime unbanDate)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();
            var accountBan = new AccountBanned
            {
                Id = accountId,
                Active = 1,
                Banreason = banReason,
                Bannedby = bannedBy,
                Bandate = DateTime.UtcNow.ToUnixTime(),
                Unbandate = unbanDate.ToUnixTime()
            };

            _ = authDatabase.AccountBanneds.Add(accountBan);
            _ = authDatabase.SaveChanges();
            _forgeCache.UpdateKey(AuthCacheKeys.ACCOUNT_BANS);
        }

        public void BanIp(string ipAddress, string banReason, string bannedBy, DateTime unbanDate)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var ipBan = new IpBanned
            {
                Ip = ipAddress,
                Banreason = banReason,
                Bannedby = bannedBy,
                Bandate = DateTime.UtcNow.ToUnixTime(),
                Unbandate = unbanDate.ToUnixTime()
            };

            _ = authDatabase.IpBanneds.Add(ipBan);
            _ = authDatabase.SaveChanges();
            _forgeCache.UpdateKey(AuthCacheKeys.IP_BANS);
        }

        public void UnbanAccount(uint accountId)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();
            var accountBan = authDatabase.AccountBanneds.FirstOrDefault(x => x.Id == accountId);

            if (accountBan != null)
            {
                accountBan.Active = 0;
                accountBan.Unbandate = DateTime.UtcNow.ToUnixTime();
                _ = authDatabase.SaveChanges();
                _forgeCache.UpdateKey(AuthCacheKeys.ACCOUNT_BANS);
            }
        }

        public void UnbanIp(string ipAddress)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();
            var ipBan = authDatabase.IpBanneds.FirstOrDefault(x => x.Ip == ipAddress);

            if (ipBan != null)
            {
                ipBan.Unbandate = DateTime.UtcNow.ToUnixTime();
                _ = authDatabase.SaveChanges();
                _forgeCache.UpdateKey(AuthCacheKeys.IP_BANS);
            }
        }
    }
}