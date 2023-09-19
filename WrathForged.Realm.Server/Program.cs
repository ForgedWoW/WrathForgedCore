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
                    .AddJsonFile("WrathForged.Realm.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();

DependencyInjectionContainer container = new DependencyInjectionContainer();
container.Configure(c =>
{
    c.RegisterCommon(configuration);
    c.RegisterDatabase(configuration, Log.Logger);
    c.Export<WoWClientServer>().WithCtorParam(() => PacketScope.ClientToRealm).Lifestyle.Singleton();
});

container.InitializeCommon();

container.Locate<WoWClientServer>().Start();

Log.Logger.Information("Realm Server started.");
var notifier = container.Locate<ProgramExitNotifier>();

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    notifier.NotifyStop("ctrl+c pressed.");
};

container.Locate<CommandLineReader>().ReadCommandLineUntilProgramExit();
