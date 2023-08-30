// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.World;

namespace WrathForged.Database
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterDatabase(this ContainerBuilder builder, IConfiguration configuration)
        {
            var logLevelConfig = configuration["Serilog:OtherLogLevels:Microsoft.EntityFrameworkCore.Database.Command"];
            var logLevel = string.IsNullOrEmpty(logLevelConfig)
                ? LogLevel.Error
                : Enum.Parse<LogLevel>(logLevelConfig);

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog().AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name && level == logLevel);
            });

            builder.RegisterType<AuthDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<AuthDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("auth"), ServerVersion.AutoDetect(configuration.GetConnectionString("auth"))).Options)
                .InstancePerLifetimeScope();
            builder.RegisterType<WorldDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<WorldDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("world"), ServerVersion.AutoDetect(configuration.GetConnectionString("world"))).Options)
                .InstancePerLifetimeScope();
            builder.RegisterType<CharacterDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<CharacterDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("characters"), ServerVersion.AutoDetect(configuration.GetConnectionString("characters"))).Options)
                .InstancePerLifetimeScope();

            return builder;
        }

        public static IContainer ShutdownDatabase(this IContainer container)
        {
            container.Resolve<AuthDatabase>().Dispose();
            container.Resolve<WorldDatabase>().Dispose();
            container.Resolve<CharacterDatabase>().Dispose();
            return container;
        }
    }
}