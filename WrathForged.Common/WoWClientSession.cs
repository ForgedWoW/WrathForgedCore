// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
using WrathForged.Common.Time;

namespace WrathForged.Common;

public partial class WoWClientSession
{
    private readonly ServerUpdateLoop _serverUpdateLoop;

    public WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ClassFactory classFactory)
    {
        Security = classFactory.Locate<SessionSecurity>();
        Network = classFactory.Locate<SessionNetwork>(new { clientSocket, packetBuffer, packetBufferBaseStream = (MemoryStream)packetBuffer.Reader.BaseStream });
        ClientTime = classFactory.Locate<ClientTime>(new { clientSession = this });
        _serverUpdateLoop = classFactory.Locate<ServerUpdateLoop>();
        _serverUpdateLoop.RegisterUpdateLoop(ClientTime, UpdateLoopPriorities.CLIENT_TIME);

        Network.ClientSocket.OnDisconnect += (sender, args) => _serverUpdateLoop.UnregisterUpdateLoop(ClientTime, UpdateLoopPriorities.CLIENT_TIME);
    }

    public enum AuthState
    {
        LoggedOut,
        AwaitingCredentials,
        LoggedIn,
    };

    public SessionSecurity Security { get; }

    public SessionNetwork Network { get; }

    public ClientTime ClientTime { get; }
}