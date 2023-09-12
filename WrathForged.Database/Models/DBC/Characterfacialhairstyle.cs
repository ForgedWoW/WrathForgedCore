using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Characterfacialhairstyle
{
    public int Id { get; set; }

    public int RaceId { get; set; }

    public int SexId { get; set; }

    public int VariationId { get; set; }

    public int Geoset1 { get; set; }

    public int Geoset2 { get; set; }

    public int Geoset3 { get; set; }

    public int Geoset4 { get; set; }

    public int Geoset5 { get; set; }
}
