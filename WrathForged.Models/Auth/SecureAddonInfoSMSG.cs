// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Auth;

[ForgedSerializable]
public class SecureAddonInfoSMSG
{
    [SerializableProperty(0)]
    public SecureAddonStatus Status { get; set; }

    [SerializableProperty(1)]
    public bool InfoProvided { get; set; }

    [SerializableProperty(2)]
    [SerializerConditionBool(1)]
    public bool DoesNotHaveKey { get; set; }

    [SerializableProperty(3)]
    [SerializerConditionBool(2)]
    public byte[] AddonPublicKey { get; set; } = [];

    [SerializableProperty(4)]
    public uint Visible { get; set; }

    [SerializableProperty(5)]
    public bool UrlProvided { get; set; }
}
