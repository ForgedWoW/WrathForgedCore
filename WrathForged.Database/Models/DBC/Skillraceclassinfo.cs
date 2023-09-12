using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Skillraceclassinfo
{
    public int Id { get; set; }

    public int? SkillId { get; set; }

    public int RaceMask { get; set; }

    public int ClassMask { get; set; }

    public int Flags { get; set; }

    public int MinLevel { get; set; }

    public int? SkillTierId { get; set; }

    public int? SkillCostIndex { get; set; }

    public virtual Skillline? Skill { get; set; }

    public virtual Skillcostsdatum? SkillCostIndexNavigation { get; set; }

    public virtual Skilltier? SkillTier { get; set; }
}
