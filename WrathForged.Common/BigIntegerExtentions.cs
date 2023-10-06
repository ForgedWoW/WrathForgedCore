// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Common;

public static class BigIntegerExtensions
{
    public static byte[] GetBytes(this BigInteger bigInteger, int count) => new Memory<byte>(bigInteger.ToByteArray())[..count].ToArray();

    public static byte[] ToProperByteArray(this BigInteger b)
    {
        var bytes = b.ToByteArray();
        if (b.Sign == 1 && bytes.Length > 1 && bytes[^1] == 0)
            Array.Resize(ref bytes, bytes.Length - 1);
        return bytes;
    }

    // http://stackoverflow.com/a/5649264
    public static BigInteger ToPositiveBigInteger(this byte[] bytes)
    {
        return new BigInteger(bytes.Concat(new byte[] { 0 }).ToArray());
    }

    public static ushort SwitchEndian(this ushort old)
    {
        var tmp = BitConverter.GetBytes(old);
        Array.Reverse(tmp);
        return BitConverter.ToUInt16(tmp, 0);
    }

    /// <summary>
    /// Returns <see cref="BigInteger"/> in byte form but truncates
    /// the final field if it's 0.
    /// (The MSB)
    /// </summary>
    /// <param name="bigInt"></param>
    /// <returns></returns>
    public static byte[] ToCleanByteArray(this BigInteger bigInt)
    {
        //We removed the array header memory hack
        //due to it likely causes the runtime crashes
        byte[] array = bigInt.ToByteArray();

        if (array.Length == 0 || array[^1] != 0)
            return array;

        byte[] temp = new byte[array.Length - 1];
        Array.Copy(array, temp, temp.Length);

        return temp;
    }

    //Bouncy has this implemented
    public static BigInteger ModPow(this BigInteger number, BigInteger exp, BigInteger modulus)
    {
        return BigInteger.ModPow(number, exp, modulus);
    }

    //From Jackpoz's 3.3.5 bot
    /// <summary>
    /// places a non-negative value (0) at the MSB, then converts to a BigInteger.
    /// This ensures a non-negative value without changing the binary representation.
    /// </summary>
    public static BigInteger ToBigInteger(this byte[] array)
    {
        //This can't be hacked like with ToCleanArray
        byte[] temp;
        if ((array[^1] & 0x80) == 0x80)
        {
            temp = new byte[array.Length + 1];
            temp[array.Length] = 0;

            //Copies the contents of the array into temp
            //There is no way to memory hack this
            Array.Copy(array, temp, array.Length);
        }
        else
            temp = array;

        return new BigInteger(temp);
    }

    public static byte[] Pad(this byte[] bytes, int count)
    {
        Array.Resize(ref bytes, count);
        return bytes;
    }
}