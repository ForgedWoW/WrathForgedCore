// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Enum
{
    public enum AuthStatus
    {
        WOW_SUCCESS = 0x00,
        WOW_FAIL_BANNED = 0x03,
        WOW_FAIL_UNKNOWN_ACCOUNT = 0x04,
        WOW_FAIL_INCORRECT_PASSWORD = 0x05,
        WOW_FAIL_ALREADY_ONLINE = 0x06,
        WOW_FAIL_NO_TIME = 0x07,
        WOW_FAIL_DB_BUSY = 0x08,
        WOW_FAIL_VERSION_INVALID = 0x09,
        WOW_FAIL_VERSION_UPDATE = 0x0A,
        WOW_FAIL_INVALID_SERVER = 0x0B,
        WOW_FAIL_SUSPENDED = 0x0C,
        WOW_FAIL_FAIL_NOACCESS = 0x0D,
        WOW_SUCCESS_SURVEY = 0x0E,
        WOW_FAIL_PARENTCONTROL = 0x0F,
        WOW_FAIL_LOCKED_ENFORCED = 0x10,
        WOW_FAIL_TRIAL_ENDED = 0x11,
        WOW_FAIL_USE_BATTLENET = 0x12,
        WOW_FAIL_ANTI_INDULGENCE = 0x13,
        WOW_FAIL_EXPIRED = 0x14,
        WOW_FAIL_NO_GAME_ACCOUNT = 0x15,
        WOW_FAIL_CHARGEBACK = 0x16,
        WOW_FAIL_INTERNET_GAME_ROOM_WITHOUT_BNET = 0x17,
        WOW_FAIL_GAME_ACCOUNT_LOCKED = 0x18,
        WOW_FAIL_UNLOCKABLE_LOCK = 0x19,
        WOW_FAIL_CONVERSION_REQUIRED = 0x20,
        WOW_FAIL_DISCONNECTED = 0xFF
    }
}