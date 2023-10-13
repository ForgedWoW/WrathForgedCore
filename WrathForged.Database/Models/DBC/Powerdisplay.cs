// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("PowerDisplay.dbc")]
public partial class Powerdisplay : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int ActualType { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
    public string? GlobalstringBaseTag { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.BYTE)]
    public byte Red { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.BYTE)]
    public byte Green { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.BYTE)]
    public byte Blue { get; set; }

    // Virtual collections and references are not annotated with DBCPropertyBinding
    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
    public virtual ICollection<Vehicle> VehiclePowerDisplayId1Navigations { get; set; } = new List<Vehicle>();
    public virtual ICollection<Vehicle> VehiclePowerDisplayId2Navigations { get; set; } = new List<Vehicle>();
    public virtual ICollection<Vehicle> VehiclePowerDisplayId3Navigations { get; set; } = new List<Vehicle>();
}
