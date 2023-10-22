// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using SSDI;
using WrathForged.Authorization.Server;
using WrathForged.Common;
using WrathForged.Common.Caching;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Networking;
using WrathForged.Database;
using WrathForged.Models;
using WrathForged.Serialization.Models;

var initializationStart = DateTime.UtcNow;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Authorization.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();
var container = new DependencyInjectionContainer();
container.Configure(c =>
{
    _ = c.ExportInstance(configuration).As<IConfiguration>();
    _ = c.RegisterCommon(configuration);
    _ = c.RegisterDatabase(configuration, Log.Logger);
    _ = c.RegisterAuth();
    ModelsDependencyInjection.RegisterModels(); // do not remove this. it allows Models to be reflected on. c# does not load assemblies unless they are used.
});

container.InitializeCommon();
container.Locate<CacheBuilder>().BuildAuthCache();
container.Locate<WoWClientServer>().Start();

Log.Logger.Information("Auth Server started in {InitializationTime}.", (DateTime.UtcNow - initializationStart).ToReadableString());
var notifier = container.Locate<ProgramExitNotifier>();

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    notifier.NotifyStop("ctrl+c pressed.");
};

container.Locate<CommandLineReader>().ReadCommandLineUntilProgramExit();
