using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.Configuration;
using WrathForged.Authorization.Server.Workers;

namespace WrathForged.Authorization.Server
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterAuth(this ContainerBuilder builder, IConfiguration configuration)
        {
            builder.RegisterType<RealmListCache>().SingleInstance();
            return builder;
        }
    }
}
