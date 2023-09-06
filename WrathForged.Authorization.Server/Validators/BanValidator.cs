// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Authorization.Server.Validators
{
    public class BanValidator
    {
        public enum BanType
        {
            None,
            Banned,
            Suspended
        }

        private readonly ForgeCache _forgeCache;
        private readonly ClassFactory _classFactory;

        public BanValidator(ForgeCache forgeCache, ClassFactory classFactory)
        {
            _forgeCache = forgeCache;
            _classFactory = classFactory;
        }

        public BanType GetBanState(uint accountId, string ipAddress)
        {
            if (_forgeCache.TryGet(AuthCacheKeys.ACCOUNT_BANS, out Dictionary<uint, AccountBanned> accountBans) && accountBans.TryGetValue(accountId, out var accountBan))
            {
                return accountBan.Active ? BanType.Banned : BanType.Suspended;
            }

            if (_forgeCache.TryGet(AuthCacheKeys.IP_BANS, out Dictionary<string, IpBanned> ipBans) && ipBans.TryGetValue(ipAddress, out var ipBan))
            {
                if (ipBan.Unbandate == default)
                    return BanType.Banned;
                else if (ipBan.Unbandate.FromUnixTime() > DateTime.UtcNow)
                    return BanType.Suspended;
            }

            return BanType.None;
        }

        /// <summary>
        ///     if unbanDate is not set, the ban is permanent
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="banReason"></param>
        /// <param name="bannedBy"></param>
        /// <param name="unbanDate"></param>
        public void BanAccount(uint accountId, string banReason, string bannedBy, DateTime unbanDate = default)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();
            var accountBan = new AccountBanned
            {
                Id = accountId,
                Active = unbanDate == default,
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
                accountBan.Active = false;
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