// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Time;

public static class TimeUtil
{
    public static readonly DateTime UnixTimeStart = new(1970, 1, 1, 0, 0, 0);
    public const int TICKS_PER_SECOND = 10000;
    private const long TICKS_SINCE_1970 = 621355968000000000; // .NET ticks for 1970
    public static DateTime ApplicationStartTime { get; internal set; }

    /// <summary>
    /// Gets the system uptime.
    /// </summary>
    /// <returns>the system uptime in milliseconds</returns>
    public static uint GetSystemTime() => (uint)Environment.TickCount;

    /// <summary>
    /// Gets the time since the Unix epoch.
    /// </summary>
    /// <returns>the time since the Unix epoch in seconds</returns>
    public static uint GetEpochTime() => (uint)((DateTime.UtcNow.Ticks - TICKS_SINCE_1970) / TimeSpan.TicksPerSecond);

    public static DateTime GetDateTimeFromUnixTime(uint unixTime) => new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTime);

    public static DateTime GetUTCTimeSeconds(long seconds) => UnixTimeStart.AddSeconds(seconds);

    public static DateTime GetUTCTimeMillis(long milliseconds) => UnixTimeStart.AddMilliseconds(milliseconds);

    /// <summary>
    /// Gets the system uptime.
    /// </summary>
    /// <remarks>
    /// Even though this returns a long, the original value is a 32-bit integer,
    /// so it will wrap back to 0 after approximately 49 and half days of system uptime.
    /// </remarks>
    /// <returns>the system uptime in milliseconds</returns>
    public static long GetSystemTimeLong() => (uint)Environment.TickCount;

    /// <summary>
    /// Gets the time between the Unix epoch and a specific <see cref="DateTime">time</see>.
    /// </summary>
    /// <param name="time">the end time</param>
    /// <returns>the time between the unix epoch and the supplied <see cref="DateTime">time</see> in seconds</returns>
    public static uint GetEpochTimeFromDT() => DateTime.Now.GetEpochTimeFromDT();

    public static int ToMilliSecondsInt(int ticks) => ticks / TICKS_PER_SECOND;

    public static uint GetMillisecondsSinceStartup() => (uint)(DateTime.Now - ApplicationStartTime).TotalMilliseconds;
}
