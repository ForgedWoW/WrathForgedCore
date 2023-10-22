// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
using Serilog;
using SSDI;
using SSDI.Registration;
using WrathForged.Common.Caching;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Cryptography;
using WrathForged.Common.DBC;
using WrathForged.Common.External;
using WrathForged.Common.Localization;
using WrathForged.Common.Networking;
using WrathForged.Common.Observability;
using WrathForged.Common.RBAC;
using WrathForged.Common.Scripting;
using WrathForged.Common.Scripting.Interfaces;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Common.Serialization;
using WrathForged.Common.Threading;
using WrathForged.Common.Time;
using WrathForged.Common.Validators;
using WrathForged.Database;
using WrathForged.Database.DBC;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common;

public static class DependencyInjection
{
    public static ExportRegistration RegisterCommon(this ExportRegistration builder, IConfiguration configuration)
    {
        var startTime = DateTime.UtcNow;
        TimeUtil.ApplicationStartTime = DateTime.Now;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"```````````````````````````````````````````````````````````````````````````````````````");
        Console.WriteLine(@"███████╗ ██████╗ ██████╗  ██████╗ ███████╗██████╗      ██████╗ ██████╗ ██████╗ ███████╗");
        Console.WriteLine(@"██╔════╝██╔═══██╗██╔══██╗██╔════╝ ██╔════╝██╔══██╗    ██╔════╝██╔═══██╗██╔══██╗██╔════╝");
        Console.WriteLine(@"█████╗  ██║   ██║██████╔╝██║  ███╗█████╗  ██║  ██║    ██║     ██║   ██║██████╔╝█████╗  ");
        Console.WriteLine(@"██╔══╝  ██║   ██║██╔══██╗██║   ██║██╔══╝  ██║  ██║    ██║     ██║   ██║██╔══██╗██╔══╝  ");
        Console.WriteLine(@"██║     ╚██████╔╝██║  ██║╚██████╔╝███████╗██████╔╝    ╚██████╗╚██████╔╝██║  ██║███████╗");
        Console.WriteLine(@"╚═╝      ╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═════╝      ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝");
        Console.WriteLine($"{Process.GetCurrentProcess().ProcessName,87}");
        Console.WriteLine(@"```````````````````````````````````````````````````````````````````````````````````````");
        Console.WriteLine("https://github.com/ForgedWoW/WrathForgedCore \r\n");
        Console.ResetColor();

        Log.Logger = new LoggerConfiguration()
                     .ReadFrom.Configuration(configuration)
                     .Enrich.FromLogContext()
                     .CreateLogger();

        var classFactory = new ClassFactory();
        var exitNotifier = new ProgramExitNotifier(Log.Logger, classFactory);

        exitNotifier.ExitProgram += (sender, e) =>
        {
            Log.Logger.Information("WrathForged.Common is shutting down.");
        };

        exitNotifier.ExitProgramLate += (sender, e) =>
        {
            Log.CloseAndFlush();
        };

        _ = builder.ExportInstance(configuration).As<IConfiguration>().Lifestyle.Singleton();
        _ = builder.ExportInstance(classFactory).Lifestyle.Singleton();
        _ = builder.ExportInstance(Log.Logger).As<ILogger>().Lifestyle.Singleton();
        _ = builder.ExportInstance(exitNotifier).Lifestyle.Singleton();
        _ = builder.Export<TCPServer>();
        _ = builder.Export<ForgeCache>().Lifestyle.Singleton();
        _ = builder.Export<ForgedModelSerializer>().Lifestyle.Singleton();
        _ = builder.Export<PacketRouter>().Lifestyle.Singleton();
        _ = builder.Export<PacketEncryption>();
        _ = builder.Export<MeterFactory>().Lifestyle.Singleton();
        _ = builder.Export<BackgroundWorkProcessor>().Lifestyle.Singleton();
        _ = builder.Export<RandomUtilities>().Lifestyle.Singleton();
        _ = builder.Export<CommandLineReader>().Lifestyle.Singleton();
        _ = builder.Export<DBCSerializer>().Lifestyle.Singleton();
        _ = builder.Export<DBCDeserializer>().Lifestyle.Singleton();
        _ = builder.Export<ClientLocalizer>();
        _ = builder.Export<Localizer>().Lifestyle.Singleton();
        _ = builder.Export<ScriptLoader>().Lifestyle.Singleton();
        _ = builder.Export<ForgedTCPClient>();
        _ = builder.Export<ForgedAuthorization>().Lifestyle.Singleton();
        _ = builder.Export<AttributeCache<ForgedSerializableAttribute>>().Lifestyle.Singleton();
        _ = builder.Export<AttributeCache<SerializablePropertyAttribute>>().Lifestyle.Singleton();
        _ = builder.Export<AttributeCache<DBCBoundAttribute>>().Lifestyle.Singleton();
        _ = builder.Export<AttributeCache<DBCPropertyBindingAttribute>>().Lifestyle.Singleton();
        _ = builder.Export<SessionNetwork>();
        _ = builder.Export<SessionSecurity>();
        _ = builder.Export<PacketBuffer>();
        _ = builder.Export<ClientTime>();
        _ = builder.Export<ServerUpdateLoop>().Lifestyle.Singleton();
        _ = builder.Export<BanValidator>().Lifestyle.Singleton();
        _ = builder.Export<CacheBuilder>().Lifestyle.Singleton();
        _ = builder.Export<IpStackGeoLocationService>().Lifestyle.Singleton();

        // configure OpenTelemetry
        if (configuration.GetDefaultValue("Telemetry:Enabled", false))
        {
            var metricProviderBuilder = Sdk.CreateMeterProviderBuilder();

            var url = configuration.GetDefaultValue("Telemetry:OpenTelemetryProtocol:Endpoint", "http://localhost:4317");
            _ = metricProviderBuilder.AddOtlpExporter(options =>
            {
                options.Endpoint = new Uri(url);
            });

            Log.Logger.Information("OpenTelemetryProtocol is configured to run on {Uri}.", url);

            var tracerProvider = metricProviderBuilder.Build();

            if (tracerProvider != null)
            {
                _ = builder.ExportInstance(tracerProvider).Lifestyle.Singleton();
            }
            else
            {
                Log.Logger.Warning("Telemetry is not configured or there was an error setting it up. Please configure it in the appsettings.json file.");
            }
        }

        Log.Logger.Information("WrathForged.Common initialized in {InitializationTime}.", (DateTime.UtcNow - startTime).ToReadableString());
        return builder;
    }

    public static DependencyInjectionContainer InitializeCommon(this DependencyInjectionContainer container)
    {
        var startTime = DateTime.UtcNow;
        var cf = container.Locate<ClassFactory>();
        cf.SetContainer(container);
        container.InitializeDatabase();

        var sl = container.Locate<ScriptLoader>();

        container.Configure(c =>
        {
            var config = container.Locate<IConfiguration>();
            var logger = container.Locate<ILogger>();

            foreach (var di in sl.GetAllObjectsWithInterface<IRegisterDependancyInjection>())
                di.RegisterDependancyInjection(c, config, logger);
        });

        sl.RegisterAllTypesThatUseBaseInterface<IForgedScript>();

        foreach (var f in cf.LocateAll<IOnServerInitialize>())
            f.OnServerInitialize();

        ConfigExtensionMethods.AddConverter(cf.LocateAll<IConvertConfigValue>());

        container.Locate<ILogger>().Information("WrathForged.Common initialized in {InitializationTime}.", (DateTime.UtcNow - startTime).ToReadableString());

        return container;
    }
}