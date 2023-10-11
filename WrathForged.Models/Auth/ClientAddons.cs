// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public class ClientAddons
    {
        [SerializableProperty(0)]
        private List<ClientAddonInfo> Addons { get; set; } = [];

        [SerializableProperty(1)]
        public uint LastBannedAddonTimestamp { get; set; }
    }
}
