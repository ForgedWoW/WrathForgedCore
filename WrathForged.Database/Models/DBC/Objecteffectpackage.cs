// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ObjectEffectPackage.dbc")]
public partial class Objecteffectpackage : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    // Virtual collections and references are not annotated with DBCPropertyBinding
    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
    public virtual ICollection<Gameobjectdisplayinfo> Gameobjectdisplayinfos { get; set; } = new List<Gameobjectdisplayinfo>();
    public virtual ICollection<Objecteffectpackageelem> Objecteffectpackageelems { get; set; } = new List<Objecteffectpackageelem>();
}
