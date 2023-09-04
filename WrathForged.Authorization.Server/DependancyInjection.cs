// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
using WrathForged.Authorization.Server.Caching;
using WrathForged.Authorization.Server.Services;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common.Networking;

namespace WrathForged.Authorization.Server
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterAuth(this ContainerBuilder builder)
        {
            _ = builder.RegisterType<WoWClientServer>().WithParameter(new PositionalParameter(0, Serialization.PacketScope.Auth)).SingleInstance();
            _ = builder.RegisterType<ClientLoginSerivce>().As<IPacketService>().AsSelf().SingleInstance();
            _ = builder.RegisterType<BanValidator>().SingleInstance();
            _ = builder.RegisterType<CacheBuilder>().SingleInstance();
            return builder;
        }
    }
}