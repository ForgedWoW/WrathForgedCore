// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Common
{
    public static class BigIntegerExtentions
    {
        /// <summary>
        /// Maximum length of the BigInteger in uint. (4 bytes)
        /// </summary>
        /// <remarks>Change this to suit the required level of precision.</remarks>
        private const int MAX_LENGTH = 70;

        public static byte[] GetBytes(this BigInteger bigInteger, int count) => new Memory<byte>(bigInteger.ToByteArray())[..count].ToArray();
    }
}