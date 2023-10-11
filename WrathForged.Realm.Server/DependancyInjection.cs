// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server
{
    public static class DependencyInjection
    {
        public static IExportRegistrationBlock RegisterRealm(this IExportRegistrationBlock builder)
        {
            _ = builder.Export<WoWClientServer>().WithCtorParam(() => PacketScope.ClientToRealm).Lifestyle.Singleton();
            _ = builder.Export<ForgedCommServer>().Lifestyle.Singleton();
            _ = builder.Export<WoWClientSession>().As<IWoWClientSession>();
            _ = builder.Export<RealmClientAddonInfo>().As<IPacketService>();
            return builder;
        }
    }
}