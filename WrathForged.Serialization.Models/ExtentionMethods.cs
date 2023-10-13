// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;

namespace WrathForged.Serialization.Models;

public static class ExtentionMethods
{
    public static byte[] ToCString(this string str)
    {
        var utf8StringBytes = Encoding.UTF8.GetBytes(str);
        var data = new byte[utf8StringBytes.Length + 1];
        Array.Copy(utf8StringBytes, data, utf8StringBytes.Length);
        data[^1] = 0;
        return data;
    }

    public static string FromCString(this byte[] bytes)
    {
        // Assuming the byte array ends with a null byte (0x00) which is typical for C-style strings
        var length = Array.IndexOf(bytes, (byte)0);
        if (length < 0)
            length = bytes.Length; // If no null byte is found, use the entire array
        return Encoding.UTF8.GetString(bytes, 0, length);
    }
}