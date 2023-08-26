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
            builder.RegisterType<AuthContext>().WithParameter("options", new DbContextOptionsBuilder<AuthContext>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("auth")))).InstancePerLifetimeScope();
            builder.RegisterType<WorldContext>().WithParameter("options", new DbContextOptionsBuilder<WorldContext>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("world")))).InstancePerLifetimeScope();
            builder.RegisterType<CharactersContext>().WithParameter("options", new DbContextOptionsBuilder<CharactersContext>().UseMySql(ServerVersion.AutoDetect(configuration.GetConnectionString("characters")))).InstancePerLifetimeScope();
            return builder;
        }
    }
}