// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Networking.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.CMSG_PING)]
public class PingRequest
{
    [SerializableProperty(0)]
    public int Sequence { get; set; }

    [SerializableProperty(1)]
    public int Latency { get; set; }
}
