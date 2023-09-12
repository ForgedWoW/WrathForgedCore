using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Powerdisplay
{
    public int Id { get; set; }

    public int ActualType { get; set; }

    public string? GlobalstringBaseTag { get; set; }

    public byte Red { get; set; }

    public byte Green { get; set; }

    public byte Blue { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();

    public virtual ICollection<Vehicle> VehiclePowerDisplayId1Navigations { get; set; } = new List<Vehicle>();

    public virtual ICollection<Vehicle> VehiclePowerDisplayId2Navigations { get; set; } = new List<Vehicle>();

    public virtual ICollection<Vehicle> VehiclePowerDisplayId3Navigations { get; set; } = new List<Vehicle>();
}
