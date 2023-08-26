using Microsoft.Extensions.Configuration;

namespace WrathForged.Common
{
    public static class ConfigEx
    {
        public static T GetDefaultValue<T>(this IConfiguration config, string key, T defaultValue)
        {
            var value = config[key];

            if (value == null)
                return defaultValue;

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static bool TryGetIfNotDefaultValue<T>(this IConfiguration config, string name, T defaultValue, out T value)
        {
            value = config.GetDefaultValue(name, defaultValue);

            return value.GetHashCode() != defaultValue.GetHashCode();
        }
    }

}