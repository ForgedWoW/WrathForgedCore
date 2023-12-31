﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using SSDI;
using WrathForged.Common;
using WrathForged.Common.CommandLine;
using WrathForged.Common.Networking;
using WrathForged.Common.Threading;
using WrathForged.Database;
using WrathForged.Database.Models.Auth;
using WrathForged.Models;
using WrathForged.Models.Auth.Enum;
using WrathForged.Realm.Server;
using WrathForged.Serialization.Models;

var initializationStart = DateTime.UtcNow;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Realm.Server.Config.json", false, true);

IConfiguration configuration = configBuilder.Build();

var container = new DependencyInjectionContainer();
container.Configure(c =>
{
    _ = c.ExportInstance(configuration).As<IConfiguration>();
    _ = c.RegisterCommon(configuration);
    _ = c.RegisterDatabase(configuration, Serilog.Log.Logger);
    _ = c.RegisterRealm();
    ModelsDependencyInjection.RegisterModels(); // do not remove this. it allows Models to be reflected on. c# does not load assemblies unless they are used.
});

container.InitializeCommon();
using var authDatabase = container.Locate<AuthDatabase>();

var realm = authDatabase.Realmlists.Find(configuration.GetDefaultValue("RealmId", 1));

if (realm == null)
{
    Serilog.Log.Logger.Fatal("RealmId {RealmId} does not exist in the database.", configuration.GetDefaultValue("RealmId", 1));
    return;
}

realm.Flag |= (byte)RealmFlags.Offline;
authDatabase.Update(realm);
authDatabase.SaveChanges();

container.Locate<WoWClientServer>().Start();
container.Locate<ForgedCommServer>().Start(configuration.GetDefaultValue("ForgedServerComm:Port", 8780));
container.Locate<ServerUpdateLoop>().Start();

realm = authDatabase.Realmlists.Find(configuration.GetDefaultValue("RealmId", 1)) ?? realm;
realm.Flag &= (byte)~RealmFlags.Offline;
realm.Population = 0;
authDatabase.Update(realm);
authDatabase.SaveChanges();

Serilog.Log.Logger.Information("Realm Server started in {InitializationTime}.", (DateTime.UtcNow - initializationStart).ToReadableString());
var notifier = container.Locate<ProgramExitNotifier>();

notifier.ExitProgram += (sender, e) =>
    {
        realm = authDatabase.Realmlists.Find(configuration.GetDefaultValue("RealmId", 1)) ?? realm;
        realm.Flag |= (byte)RealmFlags.Offline;
        _ = authDatabase.Update(realm);
        _ = authDatabase.SaveChanges();
    };

Console.CancelKeyPress += (sender, e) =>
{
    e.Cancel = true;
    notifier.NotifyStop("ctrl+c pressed.");
};

container.Locate<CommandLineReader>().ReadCommandLineUntilProgramExit();
