// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.AuthToClient, Enum.AuthServerOpCode.REALM_LIST)]
    public class RealmListResponse
    {
        [SerializableProperty(0, Flags = Serialization.Models.SerializationFlags.DontSerializeCollectionSize)]
        public List<AuthRealm> Realms { get; set; } = [];

        [SerializableProperty(1)]
        public byte Unk1 { get; set; } = 0x10;

        [SerializableProperty(2)]
        public byte Unk2 { get; set; } = 0x00;
    }
}
