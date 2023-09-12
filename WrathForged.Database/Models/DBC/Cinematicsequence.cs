using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Cinematicsequence
{
    public int Id { get; set; }

    public int? SoundId { get; set; }

    public int? Camera1 { get; set; }

    public int? Camera2 { get; set; }

    public int? Camera3 { get; set; }

    public int? Camera4 { get; set; }

    public int? Camera5 { get; set; }

    public int? Camera6 { get; set; }

    public int? Camera7 { get; set; }

    public int? Camera8 { get; set; }

    public virtual Cinematiccamera? Camera1Navigation { get; set; }

    public virtual Cinematiccamera? Camera2Navigation { get; set; }

    public virtual Cinematiccamera? Camera3Navigation { get; set; }

    public virtual Cinematiccamera? Camera4Navigation { get; set; }

    public virtual Cinematiccamera? Camera5Navigation { get; set; }

    public virtual Cinematiccamera? Camera6Navigation { get; set; }

    public virtual Cinematiccamera? Camera7Navigation { get; set; }

    public virtual Cinematiccamera? Camera8Navigation { get; set; }

    public virtual ICollection<Chrclass> Chrclasses { get; set; } = new List<Chrclass>();

    public virtual ICollection<Chrrace> Chrraces { get; set; } = new List<Chrrace>();

    public virtual Soundentry? Sound { get; set; }
}
