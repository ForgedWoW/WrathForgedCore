// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Characters;

namespace WrathForged.Realm.Server.Services
{
    public class AddonService : IPacketService
    {
        public AddonService(ClassFactory classFactory)
        {
            using var characterDatabase = classFactory.Locate<CharacterDatabase>();
            KnownAddons = characterDatabase.Addons.ToDictionary(a => a.Name, a => a);
            BannedAddons = [.. characterDatabase.BannedAddons];
        }

        public Dictionary<string, Addon> KnownAddons { get; }
        public List<BannedAddon> BannedAddons { get; }
    }
}
