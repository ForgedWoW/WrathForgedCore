// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Chat;

[ForgedSerializable(Serialization.Models.PacketScope.RealmToClient, Realm.Enum.RealmServerOpCode.SMSG_NOTIFICATION)]
public class ChatNotification
{
    [SerializableProperty(0, FixedCollectionSize = 1)]
    public string NullTerminator { get; set; } = "\0";

    [SerializableProperty(1, FixedCollectionSize = 1023)]
    public string Message { get; set; } = string.Empty;
}
