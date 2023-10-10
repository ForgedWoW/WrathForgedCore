// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Caching;
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
    public class SessionNetwork(ClientSocket clientSocket, PacketBuffer packetBuffer, MemoryStream packetBufferBaseStream, ForgedModelSerializer forgedModelSerializer,
                                AttributeCache<ForgedSerializableAttribute> forgedSerializableAttributeCache, AttributeCache<SerializablePropertyAttribute> serializableAttributeCache)
    {
        private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;
        private readonly AttributeCache<ForgedSerializableAttribute> _forgedSerializableAttributeCache = forgedSerializableAttributeCache;
        private readonly AttributeCache<SerializablePropertyAttribute> _serializableAttributeCache = serializableAttributeCache;

        public int Latency { get; set; }
        public DateTime LastPing { get; set; } = DateTime.UtcNow;
        public int OverspeedPingCount { get; set; }

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
                var att = _forgedSerializableAttributeCache.GetAttributeFromObject(obj) ?? throw new InvalidOperationException($"ForgedSerializableAttribute is not defined on object {obj.GetType().Name}. Please populate packetId parameter or update the model to include ForgedSerializableAttribute.");

                if (att.PacketIDs.Length == 0)
                    throw new InvalidOperationException($"PacketIDs in ForgedSerializableAttribute on object {obj.GetType().Name} is not defined. Please populate packetId parameter or update the models ForgedSerializableAttribute to include at least one OpCode.");

                packetId = new PacketId(att.PacketIDs.First(), att.Scope);
            }

            var packet = NewClientMessage(packetId, packetHeaderType, contentLengthType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }


        /// <summary>
        ///     Sends the model to the client. if the model does not have a ForgedSerializableAttribute defined, it will not be sent.
        ///     if opCode is not defined, it will use the first opCode defined in the ForgedSerializableAttribute.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="opCode"></param>
        public void Send(object obj, RealmServerOpCode? opCode = null)
        {
            if (obj == null)
                return;

            PacketId packetId;

            if (opCode == null)
            {
                var att = _forgedSerializableAttributeCache.GetAttributeFromObject(obj) ?? throw new InvalidOperationException($"ForgedSerializableAttribute is not defined on object {obj.GetType().Name}. Please populate packetId parameter or update the model to include ForgedSerializableAttribute.");

                if (att.PacketIDs.Length == 0)
                    throw new InvalidOperationException($"PacketIDs in ForgedSerializableAttribute on object {obj.GetType().Name} is not defined. Please populate packetId parameter or update the models ForgedSerializableAttribute to include at least one OpCode.");

                packetId = new PacketId(att.PacketIDs.First(), PacketScope.RealmToClient);
            }
            else
            {
                packetId = new PacketId(opCode.Value, PacketScope.RealmToClient);
            }

            var packet = NewClientMessage(packetId, PacketHeaderType.WithBELength, ContentLengthType.UShort);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }

        public void Send(object obj, PacketScope scope, PacketHeaderType packetHeaderType = PacketHeaderType.WithBELength, ContentLengthType contentLengthType = ContentLengthType.UShort, byte[]? header = null)
        {
            if (obj == null)
                return;

            var att = _forgedSerializableAttributeCache.GetAttributeFromObject(obj) ?? throw new InvalidOperationException($"ForgedSerializableAttribute is not defined on object {obj.GetType().Name}. Please populate packetId parameter or update the model to include ForgedSerializableAttribute.");

            if (att.PacketIDs.Length == 0)
                throw new InvalidOperationException($"PacketIDs in ForgedSerializableAttribute on object {obj.GetType().Name} is not defined. Please populate packetId parameter or update the models ForgedSerializableAttribute to include at least one OpCode.");

            var packetId = new PacketId(att.PacketIDs.First(), scope);

            var packet = NewClientMessage(packetId, packetHeaderType, contentLengthType, header);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }
    }
}