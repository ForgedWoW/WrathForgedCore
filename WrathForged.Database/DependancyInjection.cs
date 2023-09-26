﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Grace.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.DBC;
using WrathForged.Database.Models.World;
using WrathForged.Database.Updates;
using Z.EntityFramework.Plus;

namespace WrathForged.Database
{
    public static class DependancyInjection
    {
        public static IExportRegistrationBlock RegisterDatabase(this IExportRegistrationBlock builder, IConfiguration configuration, Serilog.ILogger logger)
        {
            var loggerFactory = new LoggerFactory().AddSerilog(logger);

            _ = builder.Export<AuthDatabase>()
                .WithCtorParam(() => new DbContextOptionsBuilder<AuthDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("auth"), ServerVersion.AutoDetect(configuration.GetConnectionString("auth"))).Options).Named("options");

            _ = builder.Export<WorldDatabase>()
                .WithCtorParam(() => new DbContextOptionsBuilder<WorldDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("world"), ServerVersion.AutoDetect(configuration.GetConnectionString("world"))).Options).Named("options");

            _ = builder.Export<CharacterDatabase>()
                .WithCtorParam(() => new DbContextOptionsBuilder<CharacterDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMySql(configuration.GetConnectionString("characters"), ServerVersion.AutoDetect(configuration.GetConnectionString("characters"))).Options).Named("options");

            _ = builder.Export<DBCDatabase>()
                .WithCtorParam(() => new DbContextOptionsBuilder<DBCDatabase>()
                .UseLoggerFactory(loggerFactory)
                .UseMemoryCache(new MemoryCache(new MemoryCacheOptions()))
                .UseMySql(configuration.GetConnectionString("dbc"), ServerVersion.AutoDetect(configuration.GetConnectionString("dbc"))).Options).Named("options");

            var slidingTimeoutstr = configuration["Database:SlidingCacheTimeout_Hours"];
            var hours = 2;

            if (!string.IsNullOrEmpty(slidingTimeoutstr) && int.TryParse(slidingTimeoutstr, out var parsedTimeout))
                hours = parsedTimeout;

            var options = new MemoryCacheEntryOptions() { SlidingExpiration = TimeSpan.FromHours(hours) };
            var queryCache = new ForgeDBCache(new MemoryCacheOptions(), loggerFactory);
            QueryCacheManager.Cache = queryCache;
            QueryCacheManager.DefaultMemoryCacheEntryOptions = options;
            _ = builder.ExportInstance(queryCache).As<ForgeDBCache>().Lifestyle.Singleton();

            _ = builder.Export<DatabaseUpdater>().Lifestyle.Singleton();

            return builder;
        }

        public static void InitializeDatabase(this DependencyInjectionContainer container) => container.Locate<DatabaseUpdater>().Update();

        public static void ShutdownDatabase(this DependencyInjectionContainer container)
        {
            var logger = container.Locate<Serilog.ILogger>();
            logger.Information("WrathForged.Database is shutting down.");
            container.Locate<AuthDatabase>().Dispose();
            container.Locate<WorldDatabase>().Dispose();
            container.Locate<CharacterDatabase>().Dispose();
            container.Locate<ForgeDBCache>().Dispose();
            logger.Information("WrathForged.Database shut down complete.");
        }
    }
}