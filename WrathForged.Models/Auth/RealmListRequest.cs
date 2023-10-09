// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.ClientToAuth, Enum.AuthServerOpCode.REALM_LIST)]
    public class RealmListRequest
    {
        [SerializableProperty(0, Flags = Serialization.Models.SerializationFlags.ReadRestOfPacket)]
        public byte[] Unk { get; set; } = [];
    }
}
