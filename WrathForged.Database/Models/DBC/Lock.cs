// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Lock.dbc")]
public partial class Lock : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Type1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? Type2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? Type3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? Type4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? Type5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? Type6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? Type7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? Type8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Index1 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Index2 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Index3 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Index4 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Index5 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Index6 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Index7 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Index8 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int Skill1 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int Skill2 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Skill3 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int Skill4 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int Skill5 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int Skill6 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int Skill7 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int Skill8 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int Action1 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int Action2 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int Action3 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int Action4 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int Action5 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int Action6 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32)]
    public int Action7 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int Action8 { get; set; }

    public virtual Locktype? Type1Navigation { get; set; }
    public virtual Locktype? Type2Navigation { get; set; }
    public virtual Locktype? Type3Navigation { get; set; }
    public virtual Locktype? Type4Navigation { get; set; }
    public virtual Locktype? Type5Navigation { get; set; }
    public virtual Locktype? Type6Navigation { get; set; }
    public virtual Locktype? Type7Navigation { get; set; }
    public virtual Locktype? Type8Navigation { get; set; }
}
