using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Cinematiccamera
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public int? SoundId { get; set; }

    public float OriginX { get; set; }

    public float OriginY { get; set; }

    public float OriginZ { get; set; }

    public float OriginFacing { get; set; }

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera1Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera2Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera3Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera4Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera5Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera6Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera7Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera8Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual Soundentry? Sound { get; set; }
}
