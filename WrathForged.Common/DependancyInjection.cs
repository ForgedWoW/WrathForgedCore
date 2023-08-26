using Autofac;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace WrathForged.Common
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterCommon(this ContainerBuilder builder, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
             .ReadFrom.Configuration(configuration)
             .Enrich.FromLogContext()
             .CreateLogger();

            builder.RegisterType<ClassFactory>().SingleInstance();
            builder.RegisterInstance(Log.Logger).SingleInstance();
            return builder;
        }

        public static IContainer InitializeCommon(this IContainer container)
        {
            container.Resolve<ClassFactory>().Initialize(container);
            return container;
        }
    }
}
