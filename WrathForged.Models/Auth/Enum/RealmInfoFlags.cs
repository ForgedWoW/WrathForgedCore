// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    [Flags]
    public enum RealmInfoFlags : byte
    {
        VersionMismatch = 0x1,
        Offline = 0x2,
    }
}
