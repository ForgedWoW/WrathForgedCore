// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;
using WrathForged.Authorization.Server.Caching;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server
{
    public static class DependancyInjection
    {
        public static IExportRegistrationBlock RegisterAuth(this IExportRegistrationBlock builder)
        {
            _ = builder.Export<WoWClientServer>().WithCtorParam(() => PacketScope.Auth).Lifestyle.Singleton();
            _ = builder.Export<BanValidator>().Lifestyle.Singleton();
            _ = builder.Export<CacheBuilder>().Lifestyle.Singleton();
            return builder;
        }
    }
}