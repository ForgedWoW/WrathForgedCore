// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Diagnostics;
using Grace.DependencyInjection;
using Microsoft.Extensions.Configuration;
using OpenTelemetry;
using OpenTelemetry.Trace;
using Serilog;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Cryptography;
using WrathForged.Common.DBC;
using WrathForged.Common.Localization;
using WrathForged.Common.Networking;
using WrathForged.Common.Observability;
using WrathForged.Common.Scripting;
using WrathForged.Common.Scripting.Interfaces;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Common.Serialization;
using WrathForged.Common.Threading;
using WrathForged.Database;

namespace WrathForged.Common
{
    public static class DependancyInjection
    {
        public static IExportRegistrationBlock RegisterCommon(this IExportRegistrationBlock builder, IConfiguration configuration)
        {
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

            // configure OpenTelemetry
            var telemetryType = configuration.GetDefaultValue("Telemetry:Types", "").Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.TrimEntries).ToList(); // Assuming you have a key like this in your JSON

            var tracerProviderBuilder = Sdk.CreateTracerProviderBuilder().AddSource(Process.GetCurrentProcess().ProcessName);

            if (telemetryType.Contains("OpenTelemetryProtocol", StringComparer.InvariantCultureIgnoreCase))
            {
                _ = tracerProviderBuilder.AddOtlpExporter(options =>
                                     {
                                         options.Endpoint = new Uri(configuration.GetDefaultValue("Telemetry:OpenTelemetryProtocol:Endpoint", "http://localhost:4317"));
                                     });
            }
            else if (telemetryType.Contains("Zipkin", StringComparer.InvariantCultureIgnoreCase))
            {
                _ = tracerProviderBuilder.AddZipkinExporter(options =>
                                     {
                                         options.Endpoint = new Uri(configuration.GetDefaultValue("Telemetry:Zipkin:Endpoint", "http://localhost:9411/api/v2/spans"));
                                     });
            }

            var tracerProvider = tracerProviderBuilder.Build();

            if (tracerProvider != null)
            {
                _ = builder.ExportInstance(tracerProvider.GetTracer(Process.GetCurrentProcess().ProcessName)).Lifestyle.Singleton();
            }
            else
            {
                Log.Logger.Warning("Telemetry is not configured or there was an error setting it up. Please configure it in the appsettings.json file.");
            }

            return builder;
        }

        public static DependencyInjectionContainer InitializeCommon(this DependencyInjectionContainer container)
        {
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

            foreach (var f in cf.ResolveAll<IOnServerInitialize>())
                f.OnServerInitialize();

            ConfigExtensionMethods.AddConverter(cf.ResolveAll<IConvertConfigValue>());

            return container;
        }
    }
}