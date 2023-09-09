// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Entities.Enum
{
    [Flags]
    public enum ObjectTypes : uint
    {
        None = 0,
        Object = 0x1,
        Item = 0x2,
        Container = 0x4,

        /// <summary>
        /// Any unit
        /// </summary>
        Unit = 0x8,

        Player = 0x10,
        GameObject = 0x20,

        /// <summary>
        /// Any Unit or GameObject
        /// </summary>
        Attackable = 0x28,

        DynamicObject = 0x40,
        Corpse = 0x80,
        AIGroup = 0x100,
        AreaTrigger = 0x200,
        All = 0xFFFF,
    }
}