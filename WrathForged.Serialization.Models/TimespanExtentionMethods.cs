using System.Text;

namespace WrathForged.Serialization.Models
{
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

            if (span.Milliseconds > 0)
                _ = formatted.Append($"{span.Milliseconds}ms ");

            return formatted.ToString().Trim();
        }
    }
}
