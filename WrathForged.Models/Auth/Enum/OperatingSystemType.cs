// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    /// <summary>
    /// Enumeration of all valid Operating Systems types.
    /// </summary>
    public enum OperatingSystemType : byte //uint8 os[4]; (Enum string)
    {
        /// <summary>
        /// Windows operating system.
        /// </summary>
        Win = 1,

        /// <summary>
        /// Unix operating system.
        /// </summary>
        Mac = 2,
    }
}