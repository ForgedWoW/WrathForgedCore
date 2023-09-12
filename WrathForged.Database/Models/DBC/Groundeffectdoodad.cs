using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Groundeffectdoodad
{
    public int Id { get; set; }

    public string? Doodadpath { get; set; }

    public int Flags { get; set; }

    public virtual ICollection<Footstepterrainlookup> Footstepterrainlookups { get; set; } = new List<Footstepterrainlookup>();

    public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId1Navigations { get; set; } = new List<Groundeffecttexture>();

    public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId2Navigations { get; set; } = new List<Groundeffecttexture>();

    public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId3Navigations { get; set; } = new List<Groundeffecttexture>();

    public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId4Navigations { get; set; } = new List<Groundeffecttexture>();
}
