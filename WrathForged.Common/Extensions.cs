// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common
{
    public static class Extensions
    {
        public static byte[] Combine(this byte[] data, params byte[][] pData)
        {
            byte[] combined = data;

            foreach (byte[] arr in pData)
            {
                int currentSize = combined.Length;

                Array.Resize(ref combined, currentSize + arr.Length);

                Buffer.BlockCopy(arr, 0, combined, currentSize, arr.Length);
            }

            return combined;
        }

        public static object[] Combine(this object[] data, params object[][] pData)
        {
            object[] combined = data;

            foreach (object[] arr in pData)
            {
                int currentSize = combined.Length;

                Array.Resize(ref combined, currentSize + arr.Length);

                Array.Copy(arr, 0, combined, currentSize, arr.Length);
            }

            return combined;
        }
    }
}