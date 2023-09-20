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
                _locale[tc.Entry] = !string.IsNullOrEmpty(tc.Content[CurrentLocale]) ? tc.Content[CurrentLocale] : tc.Content[LocaleConst.LOCALE_ENUS];
        }

        public string Localize(uint entry, string? defaultValue = null) => _locale.TryGetValue(entry, out var value) ? value : defaultValue ?? $"";
    }
}
