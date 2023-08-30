// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics;
using Autofac;
using Microsoft.Extensions.Configuration;
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
            builder.RegisterType<ClientTCPServer>().SingleInstance();
            builder.RegisterType<ForgeCache>().SingleInstance();

            return builder;
        }

        public static IContainer InitializeCommon(this IContainer container)
        {
            container.Resolve<ClassFactory>().Initialize(container);
            return container;
        }
    }
}