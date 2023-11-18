// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Localization;
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
using WrathForged.Common.Threading;
using WrathForged.Common.Time;

namespace WrathForged.Common;

public class WoWClientSession : IWoWClientSession
{
    private readonly ServerUpdateLoop _serverUpdateLoop;
    private bool _disposedValue;

    public WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ClassFactory classFactory)
    {
        Security = classFactory.Container.LocateWithPositionalParams<SessionSecurity>(this);
        Network = classFactory.Container.LocateWithPositionalParams<SessionNetwork>(clientSocket, packetBuffer, (MemoryStream)packetBuffer.Reader.BaseStream);
        ClientTime = classFactory.Container.LocateWithPositionalParams<ClientTime>(this);
        Localizer = classFactory.Container.LocateWithPositionalParams<ClientLocalizer>(Security.Account.Locale);
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

    // <inheritdoc />
    public SessionSecurity Security { get; }

    // <inheritdoc />
    public SessionNetwork Network { get; }

    // <inheritdoc />
    public ClientTime ClientTime { get; }

    // <inheritdoc />
    public ClientLocalizer Localizer { get; }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Network.Dispose();
                Security.Dispose();
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}