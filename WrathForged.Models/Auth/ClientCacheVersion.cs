// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth;

[ForgedSerializable(Serialization.Models.PacketScope.RealmToClient, Realm.Enum.RealmServerOpCode.SMSG_CLIENTCACHE_VERSION)]
public class ClientCacheVersion
{
    [SerializableProperty(0)]
    public uint Version { get; set; }
}
