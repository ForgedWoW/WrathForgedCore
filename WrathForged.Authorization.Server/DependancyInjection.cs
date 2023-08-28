// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
using Microsoft.Extensions.Configuration;
using WrathForged.Authorization.Server.Workers;

namespace WrathForged.Authorization.Server
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterAuth(this ContainerBuilder builder, IConfiguration configuration)
        {
            builder.RegisterType<CacheBuilder>().SingleInstance();
            return builder;
        }
    }
}