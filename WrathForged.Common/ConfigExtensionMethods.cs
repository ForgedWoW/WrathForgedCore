// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;

namespace WrathForged.Common;

public static class ConfigExtensionMethods
{
    private static readonly Dictionary<Type, IConvertConfigValue> _converters = [];

    public static void AddConverter(IConvertConfigValue converter) => _converters[converter.GetType()] = converter;

    public static void AddConverter(IEnumerable<IConvertConfigValue> converter)
    {
        foreach (var conv in converter)
            AddConverter(conv);
    }

    /// <summary>
    ///      Gets a value from config, if it doesn't exist, returns the <paramref name="defaultValue"/>. <see cref="IConvertConfigValue"/> is automatically used if it can convert the value. These are automatically registered at startup.
    ///      If the converter returns <see langword="null"/>, the <paramref name="defaultValue"/> is returned.
    /// </summary>
    /// <typeparam name="T">Type of Object</typeparam>
    /// <typeparam name="C">The Converter Type</typeparam>
    /// <param name="config">IConfiguration from Microsoft</param>
    /// <param name="key">Key in the confing file</param>
    /// <param name="defaultValue">If the value is not found or could not be converted, this value is returned.</param>
    /// <returns></returns>
    public static T GetDefaultValueWithConverter<C, T>(this IConfiguration config, string key, T defaultValue) where C : IConvertConfigValue
    {
        var value = config[key];
        var type = typeof(T);

        if (value == null)
        {
            Log.Logger.Warning("Failed to find {Key} in config", key);
            return defaultValue;
        }

        var retVal = _converters.TryGetValue(typeof(C), out var convertConfigValue) ? convertConfigValue.Convert<T>(value) : (T?)Convert.ChangeType(value, type);

        if (retVal == null)
        {
            Log.Logger.Warning("Failed to convert {Key} to {Type}", key, type.Name);
            return defaultValue;
        }

        return retVal;
    }

    /// <summary>
    ///      Gets a value from config, if it doesn't exist, returns the <paramref name="defaultValue"/>.
    /// </summary>
    /// <typeparam name="T">Type of Object</typeparam>
    /// <param name="config">IConfiguration from Microsoft</param>
    /// <param name="key">Key in the confing file</param>
    /// <param name="defaultValue">If the value is not found or could not be converted, this value is returned.</param>
    /// <param name="convertConfigValue">A custom converter you want to use.</param>
    /// <returns></returns>
    public static T GetDefaultValue<T>(this IConfiguration config, string key, T defaultValue, IConvertConfigValue? convertConfigValue = null)
    {
        var value = config[key];
        var type = typeof(T);

        if (value == null)
        {
            Log.Logger.Warning("Failed to find {Key} in config", key);
            return defaultValue;
        }

        var retVal = convertConfigValue != null ? convertConfigValue.Convert<T>(value) : (T?)Convert.ChangeType(value, type);

        if (retVal == null)
        {
            Log.Logger.Warning("Failed to convert {Key} to {Type}", key, type.Name);
            return defaultValue;
        }

        return retVal;
    }

    public static bool TryGetIfNotDefaultValue<T>(this IConfiguration config, string name, T defaultValue, out T value)
    {
        value = config.GetDefaultValue(name, defaultValue);

        return value?.GetHashCode() != defaultValue?.GetHashCode();
    }
}