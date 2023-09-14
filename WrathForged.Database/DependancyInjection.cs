// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.DBC;
using WrathForged.Database.Models.World;
using Z.EntityFramework.Plus;

namespace WrathForged.Database
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterDatabase(this ContainerBuilder builder, IConfiguration configuration, Serilog.ILogger logger)
        {
            var loggerFactory = new LoggerFactory().AddSerilog(logger);

            _ = builder.RegisterType<AuthDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<AuthDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("auth"), ServerVersion.AutoDetect(configuration.GetConnectionString("auth"))).Options);

            _ = builder.RegisterType<WorldDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<WorldDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("world"), ServerVersion.AutoDetect(configuration.GetConnectionString("world"))).Options);

            _ = builder.RegisterType<CharacterDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<CharacterDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("characters"), ServerVersion.AutoDetect(configuration.GetConnectionString("characters"))).Options);

            _ = builder.RegisterType<DBCDatabase>()
                .WithParameter("options", new DbContextOptionsBuilder<DBCDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMemoryCache(new MemoryCache(new MemoryCacheOptions()))
                .UseMySql(configuration.GetConnectionString("dbc"), ServerVersion.AutoDetect(configuration.GetConnectionString("dbc"))).Options);

            var slidingTimeoutstr = configuration["Database:SlidingCacheTimeout_Hours"];
            var hours = 2;

            if (!string.IsNullOrEmpty(slidingTimeoutstr) && int.TryParse(slidingTimeoutstr, out var parsedTimeout))
                hours = parsedTimeout;

            var options = new MemoryCacheEntryOptions() { SlidingExpiration = TimeSpan.FromHours(hours) };
            var queryCache = new ForgeDBCache(new MemoryCacheOptions(), loggerFactory);
            QueryCacheManager.Cache = queryCache;
            QueryCacheManager.DefaultMemoryCacheEntryOptions = options;
            _ = builder.RegisterInstance(queryCache).As<ForgeDBCache>().SingleInstance();

            return builder;
        }

        public static void ShutdownDatabase(this IContainer container)
        {
            container.Resolve<AuthDatabase>().Dispose();
            container.Resolve<WorldDatabase>().Dispose();
            container.Resolve<CharacterDatabase>().Dispose();
            container.Resolve<ForgeDBCache>().Dispose();
        }
    }
}