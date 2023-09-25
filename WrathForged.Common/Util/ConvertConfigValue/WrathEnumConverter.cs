// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Common.Util.ConvertConfigValue
{
    public class WrathEnumConverter : IConvertConfigValue
    {
        public T? Convert<T>(string value) => Enum.TryParse(typeof(T), value, out var enumValue) ? (T)enumValue : default;
    }
}