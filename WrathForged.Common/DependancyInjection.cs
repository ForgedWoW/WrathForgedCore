// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics;
using Autofac;
using Microsoft.Extensions.Configuration;
using OpenTelemetry;
using OpenTelemetry.Trace;
using Serilog;
using WrathForged.Common.CommandLine;
using WrathForged.Common.CommandLine.Commands;
using WrathForged.Common.Cryptography;
using WrathForged.Common.DBC;
using WrathForged.Common.Networking;
using WrathForged.Common.Observability;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Common.Threading;

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

            _ = builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
            _ = builder.RegisterInstance(classFactory).SingleInstance();
            _ = builder.RegisterInstance(Log.Logger).As<ILogger>().SingleInstance();
            _ = builder.RegisterInstance(exitNotifier).SingleInstance();
            _ = builder.RegisterType<TCPServer>();
            _ = builder.RegisterType<ForgeCache>().SingleInstance();
            _ = builder.RegisterType<ForgedModelDeserialization>().SingleInstance();
            _ = builder.RegisterType<PacketRouter>().SingleInstance();
            _ = builder.RegisterType<PacketEncryption>();
            _ = builder.RegisterType<MeterFactory>().SingleInstance();
            _ = builder.RegisterType<BackgroundWorkProcessor>().SingleInstance();
            _ = builder.RegisterType<RandomUtilities>().SingleInstance();
            _ = builder.RegisterType<CommandLineReader>().SingleInstance();
            _ = builder.RegisterType<ProgramExitCommand>().As<ICommandLineArgumentHandler>().SingleInstance();
            _ = builder.RegisterType<DBCSerializer>().SingleInstance();
            _ = builder.RegisterType<DBCDeserializer>().SingleInstance();

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
                _ = builder.RegisterInstance(tracerProvider.GetTracer(Process.GetCurrentProcess().ProcessName))
                       .As<Tracer>()
                       .SingleInstance();
            }
            else
            {
                Log.Logger.Warning("Telemetry is not configured or there was an error setting it up. Please configure it in the appsettings.json file.");
            }

            // Scripting

            // DI
            IOHelpers.GetAllAssembliesInDir(configuration.GetDefaultValue("Scripting:Directory", ".\\Scripts"))
                      .ForEach(assembly =>
                      {
                          _ = builder.RegisterAssemblyModules(assembly);

                          foreach (var type in assembly.GetTypes())
                          {
                              if (typeof(IRegisterDependancyInjection).IsAssignableFrom(type))
                              {
                                  var instance = Activator.CreateInstance(type) as IRegisterDependancyInjection;
                                  instance?.RegisterDependancyInjection(builder, configuration, Log.Logger);
                              }
                          }
                      });

            return builder;
        }

        public static IContainer InitializeCommon(this IContainer container)
        {
            var cf = container.Resolve<ClassFactory>();
            cf.Initialize(container);

            foreach (var f in cf.ResolveAll<IOnServerInitialize>())
                f.OnServerInitialize();

            return container;
        }
    }
}