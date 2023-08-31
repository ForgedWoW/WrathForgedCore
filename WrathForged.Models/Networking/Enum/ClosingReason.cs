// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Networking.Enum
{
    public enum ClosingReason
    {
        PacketTooLarge = 1,
        PacketCorrupt = 2,
        PacketInvalid = 3,
        PacketIncorrect = 4,
        HeaderCorrupt = 5,
        HeaderIgnored = 6,
        HeaderIncorrect = 7,
        PacketRejected = 8,
        ChannelUnhandled = 9,
        CommandUnhandled = 10,
        CommandBadPermissions = 11,
        DirectCall = 12,
        Timeout = 13
    }
}