using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Groundeffecttexture
{
    public int Id { get; set; }

    public int? DoodadId1 { get; set; }

    public int? DoodadId2 { get; set; }

    public int? DoodadId3 { get; set; }

    public int? DoodadId4 { get; set; }

    public int DoodadWeight1 { get; set; }

    public int DoodadWeight2 { get; set; }

    public int DoodadWeight3 { get; set; }

    public int DoodadWeight4 { get; set; }

    public int Density { get; set; }

    public int Sound { get; set; }

    public virtual Groundeffectdoodad? DoodadId1Navigation { get; set; }

    public virtual Groundeffectdoodad? DoodadId2Navigation { get; set; }

    public virtual Groundeffectdoodad? DoodadId3Navigation { get; set; }

    public virtual Groundeffectdoodad? DoodadId4Navigation { get; set; }
}
