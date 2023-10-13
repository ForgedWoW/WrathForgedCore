// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Networking;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.CMSG_TIME_SYNC_RESP)]
public class TimeSyncResponse
{
    [SerializableProperty(0)]
    public uint ClientTimestamp { get; set; }

    [SerializableProperty(1)]
    public uint TimeSyncCounter { get; set; }
}
