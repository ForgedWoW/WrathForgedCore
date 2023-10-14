// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Account.Enum;

public static class AccountDataType
{
    public const uint GLOBAL_CONFIG_CACHE = 0;                          // 0x01 g
    public const uint PER_CHARACTER_CONFIG_CACHE = 1;                   // 0x02 p
    public const uint GLOBAL_BINDINGS_CACHE = 2;                        // 0x04 g
    public const uint PER_CHARACTER_BINDINGS_CACHE = 3;                 // 0x08 p
    public const uint GLOBAL_MACROS_CACHE = 4;                          // 0x10 g
    public const uint PER_CHARACTER_MACROS_CACHE = 5;                   // 0x20 p
    public const uint PER_CHARACTER_LAYOUT_CACHE = 6;                   // 0x40 p
    public const uint PER_CHARACTER_CHAT_CACHE = 7;                     // 0x80 p
}
