// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Common.Networking;

namespace WrathForged.Realm.Server.RealmSession;

public class RealmClientSession : WoWClientSession
{
    public RealmClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ClassFactory classFactory) :
            base(clientSocket, packetBuffer, classFactory) => AddonInfo = classFactory.Locate<RealmClientAddonInfo>(new { session = this });

    public RealmClientAddonInfo AddonInfo { get; }
}
