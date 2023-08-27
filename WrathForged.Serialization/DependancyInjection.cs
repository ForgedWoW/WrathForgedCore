// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Autofac;
using Microsoft.Extensions.Configuration;

namespace WrathForged.Serialization
{
    public static class DependancyInjection
    {
        public static ContainerBuilder RegisterSerialization(this ContainerBuilder builder, IConfiguration configuration)
        {
            return builder;
        }
    }
}