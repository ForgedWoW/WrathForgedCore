// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature OnKill Reputation gain
/// </summary>
public partial class CreatureOnkillReputation
{
    /// <summary>
    /// Creature Identifier
    /// </summary>
    public uint CreatureId { get; set; }

    public short RewOnKillRepFaction1 { get; set; }

    public short RewOnKillRepFaction2 { get; set; }

    public sbyte MaxStanding1 { get; set; }

    public sbyte IsTeamAward1 { get; set; }

    public int RewOnKillRepValue1 { get; set; }

    public sbyte MaxStanding2 { get; set; }

    public sbyte IsTeamAward2 { get; set; }

    public int RewOnKillRepValue2 { get; set; }

    public byte TeamDependent { get; set; }
}
