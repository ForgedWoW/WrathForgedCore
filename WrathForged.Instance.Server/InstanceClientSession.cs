// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Common.Networking;

namespace WrathForged.Instance.Server;

public class InstanceClientSession : WoWClientSession
{
    public InstanceClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ClassFactory classFactory) :
            base(clientSocket, packetBuffer, classFactory)
    {
    }
}
