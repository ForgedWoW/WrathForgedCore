// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.Models.World;

namespace WrathForged.Common.Localization
{
    public class ClientLocalizer
    {
        private readonly Dictionary<uint, string> _locale = new();
        private readonly WorldDatabase _worldDatabase;

        public int CurrentLocale { get; }

        public ClientLocalizer(WorldDatabase worldDatabase, int locale)
        {
            _worldDatabase = worldDatabase;
            CurrentLocale = locale;

            foreach (var tc in _worldDatabase.TrinityStrings)
            {
                var proposed = tc.Content[CurrentLocale];
                var en = tc.Content[LocaleConst.LOCALE_ENUS];

                _locale[tc.Entry] = !string.IsNullOrEmpty(proposed)
                                    ? proposed
                                    : !string.IsNullOrEmpty(en)
                                    ? en
                                    : string.Empty;
            }
        }

        public string Localize(uint entry, string? defaultValue = null) => _locale.TryGetValue(entry, out var value) ? value : defaultValue ?? $"";
    }
}