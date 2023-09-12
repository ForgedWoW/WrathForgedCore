using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Charsection
{
    public int Id { get; set; }

    public int? RaceId { get; set; }

    public int SexId { get; set; }

    public int BaseSection { get; set; }

    public string? TextureName1 { get; set; }

    public string? TextureName2 { get; set; }

    public string? TextureName3 { get; set; }

    public int Flags { get; set; }

    public int VariationIndex { get; set; }

    public int ColorIndex { get; set; }

    public virtual Chrrace? Race { get; set; }
}
