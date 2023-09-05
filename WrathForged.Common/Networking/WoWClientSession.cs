// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common.Networking
{
    public class WoWClientSession
    {
        private byte[]? _sessionKey;
        private readonly ILogger _logger;

        public WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ILogger logger)
        {
            ClientSocket = clientSocket;
            PacketBuffer = packetBuffer;
            _logger = logger;
        }

        public byte[]? SessionKey
        {
            get => _sessionKey;
            set
            {
                _sessionKey = value;

                if (value == null)
                    return;

                PacketEncryption = new PacketEncryption(value, _logger);
            }
        }

        public bool IsEncrypted => _sessionKey != null;

        public PacketEncryption? PacketEncryption { get; private set; }
        public ClientSocket ClientSocket { get; }
        public PacketBuffer PacketBuffer { get; }
        public Account? Account { get; set; }
    }
}