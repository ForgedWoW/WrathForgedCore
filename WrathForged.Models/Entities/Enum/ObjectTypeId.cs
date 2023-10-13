// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Entities.Enum;

/// <summary>
/// Object Type Ids are used in SMSG_UPDATE_OBJECT inside realm server
/// </summary>
public enum ObjectTypeId
{
    Object = 0,
    Item = 1,
    Container = 2,
    Unit = 3,
    Player = 4,
    GameObject = 5,
    DynamicObject = 6,
    Corpse = 7,
    AIGroup = 8,
    AreaTrigger = 9,
    Count,
    None = 0xFF
}