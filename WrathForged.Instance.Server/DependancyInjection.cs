﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Instance.Server
{
    public static class DependencyInjection
    {
        public static IExportRegistrationBlock RegisterInstance(this IExportRegistrationBlock builder)
        {
            _ = builder.Export<ForgedCommServer>().Lifestyle.Singleton();
            _ = builder.Export<WoWClientServer>().WithCtorParam(() => PacketScope.ClientToInstance).Lifestyle.Singleton();
            _ = builder.Export<InstanceClientSession>().As<IWoWClientSession>();
            return builder;
        }
    }
}