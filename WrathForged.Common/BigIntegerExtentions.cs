// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Common;

public static class BigIntegerExtensions
{
    public static byte[] ToProperByteArray(this BigInteger b)
    {
        var bytes = b.ToByteArray();
        if (b.Sign == 1 && bytes.Length > 1 && bytes[^1] == 0)
            Array.Resize(ref bytes, bytes.Length - 1);
        return bytes;
    }

    // http://stackoverflow.com/a/5649264
    public static BigInteger ToBigInteger(this byte[] bytes) => new(bytes, true);
}