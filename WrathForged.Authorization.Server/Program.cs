using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Database;
using WrathForged.Models;

var configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true);

var configuration = configBuilder.Build() as IConfiguration;

Log.Logger = new LoggerConfiguration()
             .ReadFrom.Configuration(configuration)
             .Enrich.FromLogContext()
             .CreateLogger();

var builder = new ContainerBuilder();
builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
builder.RegisterDatabase(configuration);
builder.RegisterType<ClassFactory>().SingleInstance();
builder.RegisterInstance(Log.Logger).SingleInstance();

var container = builder.Build();

container.Resolve<ClassFactory>().Initialize(container);
