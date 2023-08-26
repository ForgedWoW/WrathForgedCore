using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.Characters;
using WrathForged.Database.Models.World;

namespace WrathForged.Database
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterDatabase(this ContainerBuilder builder, IConfiguration configuration)
        {
            builder.RegisterType<AuthDatabase>().WithParameter("options", new DbContextOptionsBuilder<AuthDatabase>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("auth")))).InstancePerLifetimeScope();
            builder.RegisterType<WorldDatabase>().WithParameter("options", new DbContextOptionsBuilder<WorldDatabase>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("world")))).InstancePerLifetimeScope();
            builder.RegisterType<CharacterDatabase>().WithParameter("options", new DbContextOptionsBuilder<CharacterDatabase>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("characters")))).InstancePerLifetimeScope();
            return builder;
        }
    }
}