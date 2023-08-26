using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Authorization.Server.Workers;
using WrathForged.Common;
using WrathForged.Database;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("WrathForged.Authorization.Server.Config.json", false, true);

var configuration = configBuilder.Build() as IConfiguration;

var builder = new ContainerBuilder();
builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
builder.RegisterDatabase(configuration);
builder.RegisterCommon(configuration);
builder.RegisterType<RealmListCache>().SingleInstance();
var container = builder.Build();

container.InitializeCommon();
container.Resolve<RealmListCache>();

Console.CancelKeyPress += (sender, e) =>
{
    container.Resolve<RealmListCache>().Close();
    Log.CloseAndFlush();
};

await Task.Delay(-1);