// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Authorization.Server;
using WrathForged.Authorization.Server.Caching;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Authorization.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();

ContainerBuilder builder = new();
builder.RegisterCommon(configuration);
builder.RegisterDatabase(configuration, Log.Logger);
builder.RegisterAuth();
var container = builder.Build();
container.InitializeCommon();
container.Resolve<CacheBuilder>().Build();
container.Resolve<WoWClientServer>().TCPServer.Start();

Log.Logger.Information("Auth Server started.");
var notifier = container.Resolve<ProgramExitNotifier>();

Console.CancelKeyPress += async (sender, e) =>
{
    e.Cancel = true;
    await container.ShutdownDatabase();
    notifier.NotifyStop();
};

while (!notifier.IsExiting)
{
    await Task.Delay(1000);
}