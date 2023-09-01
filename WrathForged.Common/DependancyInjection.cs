// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics;
using Autofac;
using Microsoft.Extensions.Configuration;
using OpenTelemetry;
using OpenTelemetry.Trace;
using Serilog;
using WrathForged.Common.Networking;

namespace WrathForged.Common
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterCommon(this ContainerBuilder builder, IConfiguration configuration)
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

            var exitNotifier = new ProgramExitNotifier(Log.Logger);

            exitNotifier.ExitProgram += (sender, e) =>
            {
                Log.Logger.Information("WrathForged.Common is shutting down.");
            };

            exitNotifier.ExitProgramLate += (sender, e) =>
            {
                Log.CloseAndFlush();
            };

            builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
            builder.RegisterType<ClassFactory>().SingleInstance();
            builder.RegisterInstance(Log.Logger).SingleInstance();
            builder.RegisterInstance(exitNotifier).SingleInstance();
            builder.RegisterType<TCPServer>();
            builder.RegisterType<WoWClientServer>();
            builder.RegisterType<ForgeCache>().SingleInstance();
            builder.RegisterType<ForgedModelDeserialization>().SingleInstance();
            builder.RegisterType<PacketRouter>().SingleInstance();
            builder.RegisterType<PacketEncryption>();

            var telemetryType = configuration.GetDefaultValue("Telemetry:Types", "").Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.TrimEntries).ToList(); // Assuming you have a key like this in your JSON

            var tracerProviderBuilder = Sdk.CreateTracerProviderBuilder().AddSource(Process.GetCurrentProcess().ProcessName);

            if (telemetryType.Contains("OpenTelemetryProtocol", StringComparer.InvariantCultureIgnoreCase))
            {
                tracerProviderBuilder.AddOtlpExporter(options =>
                                     {
                                         options.Endpoint = new Uri(configuration.GetDefaultValue("Telemetry:OpenTelemetryProtocol:Endpoint", "http://localhost:4317"));
                                     });
            }
            else if (telemetryType.Contains("Zipkin", StringComparer.InvariantCultureIgnoreCase))
            {
                tracerProviderBuilder.AddZipkinExporter(options =>
                                     {
                                         options.Endpoint = new Uri(configuration.GetDefaultValue("Telemetry:Zipkin:Endpoint", "http://localhost:9411/api/v2/spans"));
                                     });
            }

            var tracerProvider = tracerProviderBuilder.Build();

            if (tracerProvider != null)
                builder.RegisterInstance(tracerProvider.GetTracer(Process.GetCurrentProcess().ProcessName))
                       .As<Tracer>()
                       .SingleInstance();
            else
                Log.Logger.Warning("Telemetry is not configured or there was an error setting it up. Please configure it in the appsettings.json file.");

            return builder;
        }

        public static IContainer InitializeCommon(this IContainer container)
        {
            container.Resolve<ClassFactory>().Initialize(container);
            return container;
        }
    }
}