// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    //Based on: https://github.com/EmberEmu/Ember/blob/spark-new/src/libs/shared/shared/Realm.h
    /// <summary>
    /// Contains flag based information about a realm.
    /// </summary>
    public enum RealmFlags : byte
    {
        None = 0x00,
        Invalid = 0x01,
        Offline = 0x02,
        SpecifyBuild = 0x04,
        Unknown1 = 0x08,
        Unknown2 = 0x10,
        Recommended = 0x20, // can set manually or allow client to do so by setting the population to 600.0f
        NewPlayers = 0x40, // can set manually or allow client to do so by setting the population to 200.0f
        Full = 0x80  // can set manually or allow client to do so by setting the population to 400.0f
    }
}