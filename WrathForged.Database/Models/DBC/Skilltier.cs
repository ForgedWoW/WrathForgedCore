// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SkillTiers.dbc")]
public partial class Skilltier : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Cost1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Cost2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Cost3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Cost4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Cost5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Cost6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Cost7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Cost8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Cost9 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Cost10 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Cost11 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Cost12 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Cost13 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Cost14 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Cost15 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Cost16 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int Value1 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int Value2 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Value3 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int Value4 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int Value5 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int Value6 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int Value7 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int Value8 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int Value9 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int Value10 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int Value11 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int Value12 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int Value13 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int Value14 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32)]
    public int Value15 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int Value16 { get; set; }

    public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();
}
