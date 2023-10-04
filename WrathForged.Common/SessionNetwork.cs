// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/ForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/ForgedCore/blob/master/LICENSE> for full information.

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

        public WoWClientPacketOut NewClientMessage(PacketId packetId, int headerSize = -1) => new(_forgedModelSerializer, packetId, headerSize);
        public WoWClientPacketOut NewClientMessage(AuthServerOpCode opCode) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.AuthToClient));
        public WoWClientPacketOut NewClientMessage(RealmServerOpCode opCode) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.RealmToClient));
        public WoWClientPacketOut NewClientMessage(InstanceServerOpCode opCode) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.InstanceToClient));
        public WoWClientPacketOut NewClientMessage(ForgedCoreOpCode opCode) => new(_forgedModelSerializer, new PacketId(opCode, PacketScope.System));

        public void Send(object obj, PacketId packetId = default)
        {
            if (obj == null)
                return;

            if (packetId == default)
            {
                var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

                if (att == null)
                    return;

                packetId = new PacketId(att.PacketIDs.First(), PacketScope.RealmToClient);
            }

            var packet = NewClientMessage(packetId);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }

        public void Send(object obj, PacketScope scope)
        {
            if (obj == null)
                return;

            var att = obj.GetType().GetCustomAttribute<ForgedSerializableAttribute>();

            if (att == null)
                return;

            var packetId = new PacketId(att.PacketIDs.First(), scope);

            var packet = NewClientMessage(packetId);
            packet.WriteObject(obj);
            ClientSocket.EnqueueWrite(packet);
        }
    }
}