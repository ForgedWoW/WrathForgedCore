// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable]
public class ClientAddonInfo()
{
    [SerializableProperty(0, OverrideType = Serialization.Models.ForgedTypeCode.CString)]
    public string Name { get; set; } = string.Empty;

    [SerializableProperty(1)]
    public bool HasKey { get; set; }

    [SerializableProperty(2)]
    public uint PublicKeyCrc { get; set; }

    [SerializableProperty(3)]
    public uint UrlCrc { get; set; }

    public SecureAddonStatus Status { get; set; }
}

