using Microsoft.Extensions.Configuration;
using WrathForged.Database.Models.World;

namespace WrathForged.Common.Localization
{
    public class Localizer : ClientLocalizer
    {
        public Localizer(WorldDatabase worldDatabase, IConfiguration configuration) : base(worldDatabase, configuration.GetDefaultValue("ServerLocale", LocaleConst.LOCALE_ENUS))
        {
        }
    }
}
