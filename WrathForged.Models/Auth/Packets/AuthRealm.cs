// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable]
public class AuthRealm
{
    [SerializableProperty(0)]
    public RealmType Type { get; set; }

    [SerializableProperty(1)]
    public RealmStatus Status { get; set; }

    [SerializableProperty(2)]
    public RealmFlags Flags { get; set; }

    [SerializableProperty(3, OverrideType = ForgedTypeCode.CString)]
    public string Name { get; set; } = string.Empty;

    [SerializableProperty(4, OverrideType = ForgedTypeCode.CString)]
    public string Address { get; set; } = string.Empty;

    [SerializableProperty(5)]
    public float Population { get; set; }

    [SerializableProperty(6)]
    public byte Characters { get; set; }

    [SerializableProperty(7)]
    public RealmCategory Category { get; set; }

    [SerializableProperty(8)]
    public byte RealmId { get; set; }

    [SerializableProperty(9)]
    [SerializerConditionHasFlag<RealmFlags>(2, RealmFlags.SpecifyBuild)]
    public RealmClientVersion Version { get; set; } = new RealmClientVersion();
}
