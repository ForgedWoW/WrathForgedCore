// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Networking
{
    [ForgedSerializable(Serialization.Models.PacketScope.RealmToClient, Realm.Enum.RealmServerOpCode.SMSG_PONG)]
    public class PingResponse
    {
        [SerializableProperty(0)]
        public int Sequence { get; set; }
    }
}
