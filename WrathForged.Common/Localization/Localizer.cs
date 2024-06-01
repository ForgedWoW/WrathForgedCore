// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Database.Models.World;

namespace WrathForged.Common.Localization;

public class Localizer(WorldDatabase worldDatabase, IConfiguration configuration) : ClientLocalizer(configuration.GetDefaultValue("ServerLocale", LocaleConst.LOCALE_ENUS), worldDatabase)
{
}