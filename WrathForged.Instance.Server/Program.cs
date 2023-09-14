// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
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

ContainerBuilder builder = new();
builder.RegisterCommon(configuration);
builder.RegisterDatabase(configuration, Log.Logger);
_ = builder.RegisterType<WoWClientServer>().WithParameter(new PositionalParameter(0, PacketScope.ClientToInstance)).SingleInstance();

var container = builder.Build();
container.InitializeCommon();

container.Resolve<WoWClientServer>().TCPServer.Start();

Log.Logger.Information("Instance Server started.");
var notifier = container.Resolve<ProgramExitNotifier>();

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    notifier.NotifyStop("ctrl+c pressed.");
};

container.Resolve<CommandLineReader>().ReadCommandLineUntilProgramExit();