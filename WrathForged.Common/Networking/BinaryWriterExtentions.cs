// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking;

public static class BinaryWriterExtentions
{
    public static int WritePackedUInt64(this BinaryWriter binWriter, ulong number)
    {
        var buffer = BitConverter.GetBytes(number);

        byte mask = 0;
        var startPos = binWriter.BaseStream.Position;

        binWriter.Write(mask);

        for (var i = 0; i < 8; i++)
        {
            if (buffer[i] != 0)
            {
                mask |= (byte)(1 << i);
                binWriter.Write(buffer[i]);
            }
        }

        var endPos = binWriter.BaseStream.Position;

        binWriter.BaseStream.Position = startPos;
        binWriter.Write(mask);
        binWriter.BaseStream.Position = endPos;

        return (int)(endPos - startPos);
    }
}