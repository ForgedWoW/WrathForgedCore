using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Areatrigger
{
    public int Id { get; set; }

    public int? ContinentId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float Radius { get; set; }

    public float BoxLength { get; set; }

    public float BoxWidth { get; set; }

    public float BoxHeight { get; set; }

    public float BoxYaw { get; set; }

    public virtual Map? Continent { get; set; }
}
