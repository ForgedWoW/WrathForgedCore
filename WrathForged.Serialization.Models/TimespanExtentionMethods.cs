// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;

namespace WrathForged.Serialization.Models;

public static class TimespanExtentionMethods
{
    public static string ToReadableString(this TimeSpan span)
    {
        var formatted = new StringBuilder();

        if (span.Days > 0)
            _ = formatted.Append($"{span.Days}d ");

        if (span.Hours > 0)
            _ = formatted.Append($"{span.Hours}h ");

        if (span.Minutes > 0)
            _ = formatted.Append($"{span.Minutes}m ");

        if (span.Seconds > 0)
            _ = formatted.Append($"{span.Seconds}s ");

        _ = formatted.Append($"{span.Milliseconds}ms ");

        return formatted.ToString().Trim();
    }
}
