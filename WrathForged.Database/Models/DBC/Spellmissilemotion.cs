// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellMissileMotion.dbc")]
public partial class Spellmissilemotion : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
    public string? ScriptBody { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int MissileCount { get; set; }
}
