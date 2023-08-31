// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Enum
{
    public enum AuthStatus
    {
        STATUS_CHALLENGE = 0,
        STATUS_LOGON_PROOF,
        STATUS_RECONNECT_PROOF,
        STATUS_AUTHED,
        STATUS_WAITING_FOR_REALM_LIST,
        STATUS_CLOSED
    };
}