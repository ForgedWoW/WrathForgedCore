// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Serialization;
using WrathForged.Database.Models.Auth;
using WrathForged.Models;
using WrathForged.Models.Networking;

namespace WrathForged.Common.Networking
{
    public class WoWClientSession
    {
        public enum AuthState
        {
            LoggedOut,
            AwaitingCredentials,
            LoggingIn,
        }

        private byte[] _sessionKey;
        private readonly ILogger _logger;
        private readonly ForgedModelSerializer _forgedModelSerializer;
        private static readonly byte[] _defaultSessionKey = new byte[32];

        public WoWClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ILogger logger, ForgedModelSerializer forgedModelSerializer)
        {
            ClientSocket = clientSocket;
            PacketBuffer = packetBuffer;
            PacketBufferBaseStream = (MemoryStream)packetBuffer.Reader.BaseStream;
            _logger = logger;
            _forgedModelSerializer = forgedModelSerializer;
            _sessionKey = _defaultSessionKey;
            PacketEncryption = new PacketEncryption(_sessionKey, logger);
        }

        public byte[] SessionKey
        {
            get => _sessionKey;
            set
            {
                _sessionKey = value;

                if (value == null)
                {
                    PacketEncryption = new PacketEncryption(_defaultSessionKey, _logger);
                    return;
                }

                PacketEncryption = new PacketEncryption(value, _logger);
            }
        }

        public bool IsEncrypted => _sessionKey != _defaultSessionKey;
        public AuthState State { get; set; } = AuthState.LoggedOut;
        public PacketEncryption PacketEncryption { get; private set; }
        public ClientSocket ClientSocket { get; }
        public PacketBuffer PacketBuffer { get; }
        public MemoryStream PacketBufferBaseStream { get; }
        public Account? Account { get; set; }
        public PasswordAuthenticator? PasswordAuthenticator { get; set; }

        public WoWClientPacketOut NewClientMessage(PacketId packetId, int headerSize = -1) => new(_forgedModelSerializer, packetId, headerSize);

        public void Write(object obj, PacketId packetId = default)
        {
            if (obj == null)
                return;

            if (packetId == default)
            {
                var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

                if (att == null)
                    return;

                packetId = new PacketId(att.PacketIDs.First(), WrathForged.Serialization.Models.PacketScope.RealmToClient);
            }

            var packet = NewClientMessage(packetId);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }
    }
}