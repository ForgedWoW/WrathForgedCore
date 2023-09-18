// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Serialization
{
    /// <summary>
    /// The packet scope sets where the packet is sent to and where it was sent from.
    /// </summary>
    public enum PacketScope
    {
        Auth,
        ClientToRealm,
        RealmToClient,
        ClientToInstance,
        InstanceToClient,
        RealmToInstance,
        InstanceToRealm
    }
}