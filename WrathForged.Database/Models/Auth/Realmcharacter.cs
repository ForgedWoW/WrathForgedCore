// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Realm Character Tracker
/// </summary>
public partial class Realmcharacter
{
    public uint Realmid { get; set; }

    public uint Acctid { get; set; }

    public byte Numchars { get; set; }
}
