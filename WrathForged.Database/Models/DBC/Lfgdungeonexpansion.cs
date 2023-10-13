// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("LFGDungeonExpansion.dbc")]
public partial class Lfgdungeonexpansion : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? LfgId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int ExpansionLevel { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int RandomId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int HardLevelMin { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int HardLevelMax { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int TargetLevelMin { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int TargetLevelMax { get; set; }

    public virtual Lfgdungeon? Lfg { get; set; }
}
