using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Skillcostsdatum
{
    public int Id { get; set; }

    public int SkillCostsId { get; set; }

    public int Cost1 { get; set; }

    public int Cost2 { get; set; }

    public int Cost3 { get; set; }

    public virtual ICollection<Skillline> Skilllines { get; set; } = new List<Skillline>();

    public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();
}
