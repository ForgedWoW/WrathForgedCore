// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public class RealmIdentification
    {
        [SerializableProperty(0)]
        public uint RegionID { get; } = 0;

        [SerializableProperty(1)]
        public uint BattlegroupID { get; } = 0;

        [SerializableProperty(2)]
        public uint RealmID { get; }
    }
}