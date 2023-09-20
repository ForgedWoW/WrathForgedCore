// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CreatureSpellData.dbc")]
public partial class Creaturespelldatum : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Spells1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? Spells2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? Spells3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? Spells4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Availability1 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Availability2 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Availability3 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Availability4 { get; set; }

    public virtual Spell? Spells1Navigation { get; set; }

    public virtual Spell? Spells2Navigation { get; set; }

    public virtual Spell? Spells3Navigation { get; set; }

    public virtual Spell? Spells4Navigation { get; set; }
}