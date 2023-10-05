// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Core.Comm
{
    [ForgedSerializable(PacketScope.System, ForgedCoreOpCode.RemoveInstanceServer)]
    public class InsanceServerShutdown
    {
        [SerializableProperty(0)]
        public uint Id { get; set; }
    }
}
