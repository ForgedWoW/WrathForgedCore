// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.SMSG_AUTH_RESPONSE)]
    public class RealmAuthErrorResponse
    {
        [SerializableProperty(0)]
        public ResponseCodes Code { get; set; }
    }
}
