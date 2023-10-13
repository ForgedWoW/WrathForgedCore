// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Updates.Enum;

/// <summary>
/// Update Types used in SMSG_UPDATE_OBJECT inside realm server
/// </summary>
public enum UpdateType : byte
{
    Values = 0,
    Movement = 1,
    Create = 2,
    CreateSelf = 3,
    OutOfRange = 4,
    Near = 5
}