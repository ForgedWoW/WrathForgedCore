// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public partial record RealmIdentification
    {
        [SerializableProperty(0)]
        public uint RegionID { get; set; }

        [SerializableProperty(1)]
        public uint BattlegroupID { get; set; }

        [SerializableProperty(2)]
        public uint RealmID { get; set; }
    }
}