// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Authorization.Server;
using WrathForged.Authorization.Server.Workers;
using WrathForged.Common;
using WrathForged.Database;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Authorization.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();

ContainerBuilder builder = new();
builder.RegisterCommon(configuration);
builder.RegisterDatabase(configuration);
builder.RegisterAuth(configuration);
var container = builder.Build();

container.InitializeCommon();
container.Resolve<CacheBuilder>().Build();

Console.CancelKeyPress += (sender, e) =>
{
    Log.CloseAndFlush();
};

await Task.Delay(-1);