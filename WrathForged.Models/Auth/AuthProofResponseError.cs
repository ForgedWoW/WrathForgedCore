// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.AuthToClient)]
    public class AuthProofResponseError
    {
        [SerializableProperty(0)]
        public AuthStatus Status { get; set; }

        [SerializableProperty(1)]
        public byte Unknown1 { get; set; }
    }
}