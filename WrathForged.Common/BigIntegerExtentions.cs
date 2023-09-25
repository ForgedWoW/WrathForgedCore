// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Numerics;

namespace WrathForged.Common
{
    public static class BigIntegerExtentions
    {
        public static byte[] GetBytes(this BigInteger bigInteger, int count) => new Memory<byte>(bigInteger.ToByteArray())[..count].ToArray();
    }
}