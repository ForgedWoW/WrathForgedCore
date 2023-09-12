using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Areagroup
{
    public int Id { get; set; }

    public int? AreaId1 { get; set; }

    public int? AreaId2 { get; set; }

    public int? AreaId3 { get; set; }

    public int? AreaId4 { get; set; }

    public int? AreaId5 { get; set; }

    public int? AreaId6 { get; set; }

    public int? NextAreaId { get; set; }

    public virtual Areatable? AreaId1Navigation { get; set; }

    public virtual Areatable? AreaId2Navigation { get; set; }

    public virtual Areatable? AreaId3Navigation { get; set; }

    public virtual Areatable? AreaId4Navigation { get; set; }

    public virtual Areatable? AreaId5Navigation { get; set; }

    public virtual Areatable? AreaId6Navigation { get; set; }

    public virtual ICollection<Areagroup> InverseNextArea { get; set; } = new List<Areagroup>();

    public virtual Areagroup? NextArea { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
