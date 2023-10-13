// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("QuestXP.dbc")]
public partial class Questxp : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Difficulty1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Difficulty2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Difficulty3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Difficulty4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Difficulty5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Difficulty6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Difficulty7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Difficulty8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Difficulty9 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Difficulty10 { get; set; }
}
