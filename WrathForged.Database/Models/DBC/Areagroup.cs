// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AreaGroup.dbc")]
public partial class Areagroup
{
    [DBCPropertyBinding(0, DBCBindingType.UINT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.UINT, CanBeNull = true)]
    public int? AreaId6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.UINT, CanBeNull = true)]
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