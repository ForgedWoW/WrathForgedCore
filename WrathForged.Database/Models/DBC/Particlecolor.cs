// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ParticleColor.dbc")]
public partial class Particlecolor : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Start1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Start2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Start3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Mid1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Mid2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Mid3 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int End1 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int End2 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int End3 { get; set; }

    // Virtual collections and references are not annotated with DBCPropertyBinding
    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
}
