// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Networking;
using WrathForged.Database;
using WrathForged.Serialization;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Instance.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();

var container = new DependencyInjectionContainer();
container.Configure(c =>
{
    _ = c.RegisterCommon(configuration);
    _ = c.RegisterDatabase(configuration, Log.Logger);
    _ = c.Export<WoWClientServer>().WithCtorParam(() => PacketScope.ClientToInstance).Lifestyle.Singleton();
});

container.InitializeCommon();

container.Locate<WoWClientServer>().Start();

Log.Logger.Information("Instance Server started.");
var notifier = container.Locate<ProgramExitNotifier>();

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    notifier.NotifyStop("ctrl+c pressed.");
};

container.Locate<CommandLineReader>().ReadCommandLineUntilProgramExit();