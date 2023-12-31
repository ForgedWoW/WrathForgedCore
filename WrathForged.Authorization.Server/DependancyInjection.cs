﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using SSDI.Registration;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server;

public static class DependencyInjection
{
    public static ExportRegistration RegisterAuth(this ExportRegistration builder)
    {
        _ = builder.Export<WoWClientServer>().WithCtorParam(PacketScope.ClientToAuth).Lifestyle.Singleton();
        _ = builder.Export<WoWClientSession>().As<IWoWClientSession>();
        return builder;
    }
}