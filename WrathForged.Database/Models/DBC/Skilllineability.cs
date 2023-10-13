// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SkillLineAbility.dbc")]
public partial class Skilllineability : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? SkillLine { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int? Spell { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int RaceMask { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int ClassMask { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int ExcludeRace { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int ExcludeClass { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int MinSkillLineRank { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int SupercededBySpell { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int AcquireMethod { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int TrivialSkillLineRankHigh { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int TrivialSkillLineRankLow { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int CharacterPoints1 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int CharacterPoints2 { get; set; }

    public virtual Skillline? SkillLineNavigation { get; set; }

    public virtual Spell? SpellNavigation { get; set; }
}
