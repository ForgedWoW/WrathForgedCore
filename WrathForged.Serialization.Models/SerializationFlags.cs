// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Serialization.Models
{
    /// <summary>
    ///     Flags for specific serialization behaviors
    /// </summary>
    [Flags]
    public enum SerializationFlags
    {
        None = 0,

        /// <summary>
        ///     If the string is reversed then it will be reversed after being deserialized.
        /// </summary>
        ReversedString = 1 << 0,

        UTF8CString = 1 << 1,
        BigIntegerWithLength = 1 << 2,
        BENetworkOrder = 1 << 3,
    }
}