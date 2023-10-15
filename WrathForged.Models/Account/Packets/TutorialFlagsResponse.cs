// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Account.Packets;

[ForgedSerializable(PacketScope.RealmToClient, RealmServerOpCode.SMSG_TUTORIAL_FLAGS)]
public class TutorialFlagsResponse
{
    [SerializableProperty(0, Flags = SerializationFlags.DontSerializeCollectionSize)]
    public required uint[] Tutorials { get; set; }
}
