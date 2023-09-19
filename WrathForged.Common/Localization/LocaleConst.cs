// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Localization
{
    public static class LocaleConst
    {
        public const string CACHE_KEY = "locale";
        public const byte LOCALE_ENUS = 0;
        public const byte LOCALE_KOKR = 1;
        public const byte LOCALE_FRFR = 2;
        public const byte LOCALE_DEDE = 3;
        public const byte LOCALE_ZHCN = 4;
        public const byte LOCALE_ZHTW = 5;
        public const byte LOCALE_ESES = 6;
        public const byte LOCALE_ESMX = 7;
        public const byte LOCALE_RURU = 8;
        public static byte CurrentLocale { get; set; } = 0;

        public static Dictionary<uint, string[]> GetLocale(this ForgeCache cache) => cache.Get<Dictionary<uint, string[]>>(CACHE_KEY) ?? new();
    }
}