// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Models;
using WrathForged.Models.Auth.Enum;
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

        public WoWClientPacketOut NewClientMessage(PacketId packetId, PacketHeaderType packetHeaderType, ContentLengthType contentLengthType = ContentLengthType.None, byte[]? header = null) => new(_forgedModelSerializer, packetId, packetHeaderType, contentLengthType, header);
        public WoWClientPacketOut NewClientMessage(AuthServerOpCode opCode, PacketHeaderType packetHeaderType, ContentLengthType contentLengthType = ContentLengthType.None, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.AuthToClient), packetHeaderType, contentLengthType, header);
        public WoWClientPacketOut NewClientMessage(RealmServerOpCode opCode, PacketHeaderType packetHeaderType = PacketHeaderType.WithBELength, ContentLengthType contentLengthType = ContentLengthType.UShort, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.RealmToClient), packetHeaderType, contentLengthType, header);
        public WoWClientPacketOut NewClientMessage(InstanceServerOpCode opCode, PacketHeaderType packetHeaderType = PacketHeaderType.WithBELength, ContentLengthType contentLengthType = ContentLengthType.UShort, byte[]? header = null) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.InstanceToClient), packetHeaderType, contentLengthType, header);

        public void Send(object obj, PacketHeaderType packetHeaderType, PacketId packetId = default, ContentLengthType contentLengthType = ContentLengthType.None, byte[]? header = null)
        {
            if (obj == null)
                return;

            if (packetId == default)
            {
                var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>() ?? throw new InvalidOperationException($"ForgedSerializableAttribute is not defined on object {obj.GetType().Name}. Please populate packetId parameter or update the model to include ForgedSerializableAttribute.");

                if (att.PacketIDs.Length == 0)
                    throw new InvalidOperationException($"PacketIDs in ForgedSerializableAttribute on object {obj.GetType().Name} is not defined. Please populate packetId parameter or update the models ForgedSerializableAttribute to include at least one OpCode.");

                packetId = new PacketId(att.PacketIDs.First(), att.Scope);
            }

            var packet = NewClientMessage(packetId, packetHeaderType, contentLengthType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }

        public void Send(object obj, PacketScope scope, PacketHeaderType packetHeaderType, ContentLengthType contentLengthType = ContentLengthType.None, byte[]? header = null)
        {
            if (obj == null)
                return;

            var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

            if (att == null)
                return;

            var packetId = new PacketId(att.PacketIDs.First(), scope);

            var packet = NewClientMessage(packetId, packetHeaderType, contentLengthType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }
    }
}