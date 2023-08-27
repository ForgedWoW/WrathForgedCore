// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.World;

namespace WrathForged.Database
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterDatabase(this ContainerBuilder builder, IConfiguration configuration)
        {
            builder.RegisterType<AuthDatabase>().WithParameter("options", new DbContextOptionsBuilder<AuthDatabase>().UseMySql(configuration.GetConnectionString("auth"), ServerVersion.AutoDetect(configuration.GetConnectionString("auth"))).Options).InstancePerLifetimeScope();
            builder.RegisterType<WorldDatabase>().WithParameter("options", new DbContextOptionsBuilder<WorldDatabase>().UseMySql(configuration.GetConnectionString("world"), ServerVersion.AutoDetect(configuration.GetConnectionString("world"))).Options).InstancePerLifetimeScope();
            builder.RegisterType<CharacterDatabase>().WithParameter("options", new DbContextOptionsBuilder<CharacterDatabase>().UseMySql(configuration.GetConnectionString("characters"), ServerVersion.AutoDetect(configuration.GetConnectionString("characters"))).Options).InstancePerLifetimeScope();
            return builder;
        }
    }
}