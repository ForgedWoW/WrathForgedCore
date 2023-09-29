// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database
{
    public static class ExtMethods
    {
        public static string ToHexString(this byte[] byteArray, bool reverse = false)
        {
            return reverse
                ? byteArray.Reverse().Aggregate("", (current, b) => current + b.ToString("X2"))
                : byteArray.Aggregate("", (current, b) => current + b.ToString("X2"));
        }
    }
}
