// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    /// <summary>
    /// Enumeration of all authentication operations.
    /// </summary>
    public enum AuthServerOpCode : uint
    {
        AUTH_LOGON_CHALLENGE = 0x00,
        AUTH_LOGON_PROOF = 0x01,
        AUTH_RECONNECT_CHALLENGE = 0x02,
        AUTH_RECONNECT_PROOF = 0x03,
        REALM_LIST = 0x10,
        XFER_INITIATE = 0x30,
        XFER_DATA = 0x31,
        XFER_ACCEPT = 0x32,
        XFER_RESUME = 0x33,
        XFER_CANCEL = 0x34,
        Maximum = 100,

        Unknown = byte.MaxValue,
    }
}