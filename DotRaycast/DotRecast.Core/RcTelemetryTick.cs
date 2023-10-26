using System;

namespace DotRecast.Core;

public readonly struct RcTelemetryTick(string key, long ticks)
{
    public readonly string Key = key;
    public readonly long Ticks = ticks;
    public long Millis => Ticks / TimeSpan.TicksPerMillisecond;
    public long Micros => Ticks / 10; // TimeSpan.TicksPerMicrosecond;
}