using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Charhairgeoset
{
    public int Id { get; set; }

    public int? RaceId { get; set; }

    public int SexId { get; set; }

    public int VariationId { get; set; }

    public int GeosetId { get; set; }

    public int Showscalp { get; set; }

    public virtual Chrrace? Race { get; set; }
}
