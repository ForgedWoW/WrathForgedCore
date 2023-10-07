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
    public static BigInteger ToBigInteger(this byte[] bytes)
    {
        return new BigInteger(bytes, true);
    }

    public static ushort SwitchEndian(this ushort old)
    {
        var tmp = BitConverter.GetBytes(old);
        Array.Reverse(tmp);
        return BitConverter.ToUInt16(tmp, 0);
    }

    //Bouncy has this implemented
    public static BigInteger ModPow(this BigInteger number, BigInteger exp, BigInteger modulus)
    {
        return BigInteger.ModPow(number, exp, modulus);
    }

    public static byte[] Pad(this byte[] bytes, int count)
    {
        Array.Resize(ref bytes, count);
        return bytes;
    }

    public static byte[] GetBytes(this BigInteger bigInt, int numBytes)
    {
        byte[] result = new byte[numBytes];

        int numBits = bigInt.GetByteCount();
        int realNumBytes = numBits >> 3;
        if ((numBits & 0x7) != 0)
            realNumBytes++;

        var data = bigInt.ToProperByteArray();

        for (int i = 0; i < realNumBytes; i++)
        {
            for (int b = 0; b < 4; b++)
            {
                if (i * 4 + b >= realNumBytes)
                    return result;
                result[i * 4 + b] = (byte)(data[i] >> (b * 8) & 0xff);
            }
        }

        return result;
    }
}