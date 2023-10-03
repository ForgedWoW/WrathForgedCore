using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.RBAC;
using WrathForged.Common.Serialization;

namespace WrathForged.Common;

public class WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ILogger logger, ForgedModelSerializer forgedModelSerializer, ForgedAuthorization forgedAuthorization)
{
    public enum AuthState
    {
        LoggedOut,
        AwaitingCredentials,
        LoggingIn,
    };

    public SessionSecurity Security { get; } = new SessionSecurity(logger, forgedAuthorization);

    public SessionNetwork Network { get; } = new SessionNetwork(clientSocket, packetBuffer, (MemoryStream)packetBuffer.Reader.BaseStream, forgedModelSerializer);
}