using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundfilterelem
{
    public int Id { get; set; }

    public int SoundFilterId { get; set; }

    public int OrderIndex { get; set; }

    public int FilterType { get; set; }

    public float Params1 { get; set; }

    public float Params2 { get; set; }

    public float Params3 { get; set; }

    public float Params4 { get; set; }

    public float Params5 { get; set; }

    public float Params6 { get; set; }

    public float Params7 { get; set; }

    public float Params8 { get; set; }

    public float Params9 { get; set; }
}
