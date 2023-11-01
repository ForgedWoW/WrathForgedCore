// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Time;

public static class TimeUtil
{
    public const int TICKS_PER_SECOND = 10000;
    public const int DAY = HOUR * 24;
    public const float FHOUR = MINUTE * 60;
    public const int HOUR = MINUTE * 60;
    public const int IN_MILLISECONDS = 1000;
    public const int MINUTE = 60;
    public const int MONTH = DAY * 30;
    public const uint UHOUR = MINUTE * 60;
    public const int WEEK = DAY * 7;
    public const int YEAR = MONTH * 12;
    private const long TICKS_SINCE_1970 = 621355968000000000; // .NET ticks for 1970
    public static DateTime ApplicationStartTime { get; internal set; }

    /// <summary>
    /// Gets the system uptime.
    /// </summary>
    /// <returns>the system uptime in milliseconds</returns>
    public static int GetSystemTime() => Environment.TickCount;

    /// <summary>
    /// Gets the time since the Unix epoch.
    /// </summary>
    /// <returns>the time since the Unix epoch in seconds</returns>
    public static long GetEpochTime() => (DateTime.UtcNow.Ticks - TICKS_SINCE_1970) / TimeSpan.TicksPerSecond;

    public static DateTime GetDateTimeFromUnixTime(uint unixTime) => DateTime.UnixEpoch.AddSeconds(unixTime);

    public static DateTime GetUTCTimeSeconds(long seconds) => DateTime.UnixEpoch.AddSeconds(seconds);

    public static DateTime GetUTCTimeMillis(long milliseconds) => DateTime.UnixEpoch.AddMilliseconds(milliseconds);

    /// <summary>
    /// Gets the system uptime.
    /// </summary>
    /// <remarks>
    /// Even though this returns a long, the original value is a 32-bit integer,
    /// so it will wrap back to 0 after approximately 49 and half days of system uptime.
    /// </remarks>
    /// <returns>the system uptime in milliseconds</returns>
    public static long GetSystemTimeLong() => Environment.TickCount;

    public static int ToMilliSecondsInt(int ticks) => ticks / TICKS_PER_SECOND;

    public static double GetMillisecondsSinceStartup() => (DateTime.Now - ApplicationStartTime).TotalMilliseconds;
}
