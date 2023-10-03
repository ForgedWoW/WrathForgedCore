// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Enum
{
    [Flags]
    public enum RealmType : byte
    {
        Normal = 0x00,
        PVP = 0x01,
        ServerType3 = 3,
        ServerType4 = 4,
        ServerType5 = 5,
        RP = 0x06,
        RPPVP = 0x07
    };
}
