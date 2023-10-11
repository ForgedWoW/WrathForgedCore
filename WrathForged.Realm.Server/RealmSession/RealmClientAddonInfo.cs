// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Models.Auth;
using WrathForged.Realm.Server.Services;

namespace WrathForged.Realm.Server.RealmSession
{
    public class RealmClientAddonInfo(RealmClientSession session, AddonService addonService, ILogger logger)
    {
        private readonly RealmClientSession _session = session;
        private readonly AddonService _addonService = addonService;
        private readonly ILogger _logger = logger;

        public ClientAddons? ClientAddons { get; private set; }

        public void SetClientAddons(ClientAddons clientAddons)
        {
            ClientAddons = clientAddons;

            foreach (var addon in clientAddons.Addons)
            {
                if (_addonService.KnownAddons.TryGetValue(addon.Name, out var knownAddon))
                {
                    if (addon.PublicKeyCrc != knownAddon.Crc)
                    {
                        if (addon.HasKey)
                        {
                            addon.Status = Models.Auth.Enum.SecureAddonStatus.Banned;
                            _logger.Warning("Account {Account} is using banned secure addon {AddonName}", _session.Security.Account.Username, addon.Name);
                        }
                        else
                            addon.Status = Models.Auth.Enum.SecureAddonStatus.SecureHidden;
                    }
                    else
                    {
                        addon.Status = Models.Auth.Enum.SecureAddonStatus.SecureHidden;
                        _logger.Debug("Account {Account} is using secure addon {AddonName}", _session.Security.Account.Username, addon.Name);
                    }
                }
                else
                {
                    addon.Status = Models.Auth.Enum.SecureAddonStatus.Banned;
                    _logger.Warning("Account {Account} is using unknown secure addon {AddonName}", _session.Security.Account.Username, addon.Name);
                }
            }
        }
    }
}
