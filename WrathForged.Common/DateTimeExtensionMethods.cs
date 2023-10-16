// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common;

public static class DateTimeExtensionMethods
{
    public const int TICKS_PER_SECOND = 10000;
    private const long TICKS_SINCE_1970 = 621355968000000000; // .NET ticks for 1970

    public static long ToUnixTime(this DateTime dateTime) => (long)(dateTime - DateTime.UnixEpoch).TotalSeconds;

    public static DateTime FromUnixTime(this long unixTime) => DateTime.UnixEpoch.AddSeconds(unixTime);

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

    /// <summary>
    /// Gets the time between the Unix epoch and a specific <see cref="DateTime">time</see>.
    /// </summary>
    /// <param name="time">the end time</param>
    /// <returns>the time between the Unix epoch and the supplied <see cref="DateTime">time</see> in seconds</returns>
    public static uint GetEpochTimeFromDT(this DateTime time) => (uint)((time.Ticks - TICKS_SINCE_1970) / 10000000L);

    public static int ToMilliSecondsInt(this DateTime time) => (int)(time.Ticks / TICKS_PER_SECOND);

    public static int ToMilliSecondsInt(this TimeSpan time) => (int)(time.Ticks / TICKS_PER_SECOND);

}