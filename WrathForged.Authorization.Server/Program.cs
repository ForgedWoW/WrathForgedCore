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

var configuration = configBuilder.Build() as IConfiguration;

var builder = new ContainerBuilder();
builder.RegisterCommon(configuration);
builder.RegisterDatabase(configuration);
builder.RegisterAuth(configuration);
var container = builder.Build();

container.InitializeCommon();
container.Resolve<RealmListCache>();

Console.CancelKeyPress += (sender, e) =>
{
    container.Resolve<RealmListCache>().Close();
    Log.CloseAndFlush();
};

await Task.Delay(-1);