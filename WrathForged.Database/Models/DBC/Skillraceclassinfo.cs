// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SkillRaceClassInfo.dbc")]
public partial class Skillraceclassinfo : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? SkillId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int RaceMask { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int ClassMask { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int MinLevel { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int? SkillTierId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int? SkillCostIndex { get; set; }

    public virtual Skillline? Skill { get; set; }

    public virtual Skillcostsdatum? SkillCostIndexNavigation { get; set; }

    public virtual Skilltier? SkillTier { get; set; }
}
