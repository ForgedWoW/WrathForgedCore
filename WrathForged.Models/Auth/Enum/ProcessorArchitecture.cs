// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Enum
{
    /// <summary>
    /// Enumeration of all valid platforms.
    /// </summary>
    public enum ProcessorArchitecture : byte //uint8 platform[4]; (Enum string)
    {
        /// <summary>
        /// 32bit platform.
        /// </summary>
        x86 = 1,

        /// <summary>
        /// 64bit platform.
        /// </summary>
        x64 = 2,
    }
}