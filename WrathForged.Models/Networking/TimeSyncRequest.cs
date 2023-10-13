// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Networking;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.SMSG_TIME_SYNC_REQ)]
public class TimeSyncRequest
{
    [SerializableProperty(0)]
    public uint TimeSyncCounter { get; set; }
}
