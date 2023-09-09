// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Updates.Enum
{
    [Flags]
    public enum UpdateFlags : uint
    {
        Self = 0x1,
        Transport = 0x2,

        /// <summary>
        /// Attack Target
        /// </summary>
        AttackingTarget = 0x4,

        /// <summary>
        /// Value depends on object type
        ///
        /// Items, Containers, GameObjects, DynamicObjects, and Corpses its high 4 bytes of guid
        /// </summary>
        Flag_0x8 = 0x8,

        /// <summary>
        /// Value depends on object type
        ///
        /// Items, Containers, GameObjects, DynamicObjects, and Corpses its low 4 bytes of guid
        /// </summary>
        Flag_0x10 = 0x10,

        /// <summary>
        /// Mobile Objects
        /// </summary>
        Living = 0x20,

        /// <summary>
        /// Stationary Objects
        /// </summary>
        StationaryObject = 0x40,

        /// <summary>
        /// For Vehicles
        /// Int: VehicleId (from Vehicle.dbc)
        /// Float: Aim Adjustment
        /// </summary>
        Vehicle = 0x80,

        /// <summary>
        /// Appears to be stationary objects on transports
        /// </summary>
        StationaryObjectOnTransport = 0x100,

        /// <summary>
        /// This is an ulong that used to be in the GAMEOBJECT_ROTATION updatefield
        /// It is 3 values packed together, but of unknown use.
        /// </summary>
        HasRotation = 0x200,
    }
}