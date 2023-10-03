// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Util.ConvertConfigValue;

public class BoolConverter : IConvertConfigValue
{
    public T? Convert<T>(string value)
    {
        if (bool.TryParse(value, out var boolValue))
            return (T)(object)boolValue;
        else if (value is "1" or "0")
            return (T)(object)(value == "1");

        return default;
    }
}