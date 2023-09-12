using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundentriesadvanced
{
    public int Id { get; set; }

    public int? SoundEntryId { get; set; }

    public float InnerRadius2D { get; set; }

    public int TimeA { get; set; }

    public int TimeB { get; set; }

    public int TimeC { get; set; }

    public int TimeD { get; set; }

    public int RandomOffsetRange { get; set; }

    public int Usage { get; set; }

    public int TimeintervalMin { get; set; }

    public int TimeintervalMax { get; set; }

    public int VolumeSliderCategory { get; set; }

    public float DuckToSfx { get; set; }

    public float DuckToMusic { get; set; }

    public float DuckToAmbience { get; set; }

    public float InnerRadiusOfInfluence { get; set; }

    public float OuterRadiusOfInfluence { get; set; }

    public int TimeToDuck { get; set; }

    public int TimeToUnduck { get; set; }

    public float InsideAngle { get; set; }

    public float OutsideAngle { get; set; }

    public float OutsideVolume { get; set; }

    public float OuterRadius2D { get; set; }

    public string? Name { get; set; }

    public virtual Soundentry? SoundEntry { get; set; }

    public virtual ICollection<Soundentry> Soundentries { get; set; } = new List<Soundentry>();
}
