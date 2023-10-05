// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Models;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Core.Comm;
using WrathForged.Models.Instance.Enum;
using WrathForged.Models.Networking;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Common
{
    public class SessionNetwork(ClientSocket clientSocket, PacketBuffer packetBuffer, MemoryStream packetBufferBaseStream, ForgedModelSerializer forgedModelSerializer)
    {
        private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;

        public ClientSocket ClientSocket { get; } = clientSocket;
        public PacketBuffer PacketBuffer { get; } = packetBuffer;
        public MemoryStream PacketBufferBaseStream { get; } = packetBufferBaseStream;

        public WoWClientPacketOut NewClientMessage(PacketId packetId, PacketHeaderType packetHeaderType, byte[]? header = null) => new(_forgedModelSerializer, packetId, packetHeaderType, header);
        public WoWClientPacketOut NewClientMessage(AuthServerOpCode opCode, PacketHeaderType packetHeaderType, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.AuthToClient), packetHeaderType, header);
        public WoWClientPacketOut NewClientMessage(RealmServerOpCode opCode, PacketHeaderType packetHeaderType, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.RealmToClient), packetHeaderType, header);
        public WoWClientPacketOut NewClientMessage(InstanceServerOpCode opCode, PacketHeaderType packetHeaderType, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.InstanceToClient), packetHeaderType, header);
        public WoWClientPacketOut NewClientMessage(ForgedCoreOpCode opCode, PacketHeaderType packetHeaderType, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.System), packetHeaderType, header);

        public void Send(object obj, PacketHeaderType packetHeaderType, PacketId packetId = default, byte[]? header = null)
        {
            if (obj == null)
                return;

            if (packetId == default)
            {
                var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

                if (att == null)
                    return;

                packetId = new PacketId(att.PacketIDs.First(), att.Scope);
            }

            var packet = NewClientMessage(packetId, packetHeaderType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }

        public void Send(object obj, PacketScope scope, PacketHeaderType packetHeaderType, byte[]? header = null)
        {
            if (obj == null)
                return;

            var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

            if (att == null)
                return;

            var packetId = new PacketId(att.PacketIDs.First(), scope);

            var packet = NewClientMessage(packetId, packetHeaderType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }
    }
}