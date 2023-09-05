// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common
{
    public static class DateTimeExt
    {
        public static DateTime UnixEpoch { get; } = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long ToUnixTime(this DateTime dateTime) => (long)(dateTime - UnixEpoch).TotalSeconds;

        public static DateTime FromUnixTime(this long unixTime) => UnixEpoch.AddSeconds(unixTime);

        /// <summary>
        /// Converts the current time and date into the time and date format of the WoW client.
        /// </summary>
        /// <returns>a packed time and date</returns>
        public static uint GetDateTimeToGameTime(this DateTime n)
        {
            var dayOfWeek = (uint)n.DayOfWeek == 0 ? 6 : ((uint)n.DayOfWeek) - 1;

            var gameTime = (uint)n.Minute & 0x3F;
            gameTime |= ((uint)n.Hour << 6) & 0x7C0;
            gameTime |= (dayOfWeek << 11) & 0x3800;
            gameTime |= ((uint)(n.Day - 1) << 14) & 0xFC000;
            gameTime |= ((uint)(n.Month - 1) << 20) & 0xF00000;
            gameTime |= ((uint)(n.Year - 2000) << 24) & 0x1F000000;

            return gameTime;
        }

        public static DateTime GetGameTimeToDateTime(this uint packedDate)
        {
            var minute = (int)(packedDate & 0x3F);
            var hour = (int)((packedDate >> 6) & 0x1F);
            //DayOfWeek dayOfWeek = (DayOfWeek) ((packedDate >> 11) & 0x3800);
            var day = (int)((packedDate >> 14) & 0x3F);
            var month = (int)((packedDate >> 20) & 0xF);
            var year = (int)((packedDate >> 24) & 0x1F);

            return new DateTime(year + 2000, month + 1, day + 1, hour, minute, 0);
        }
    }
}