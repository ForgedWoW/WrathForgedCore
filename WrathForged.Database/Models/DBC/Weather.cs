using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Weather
{
    public int Id { get; set; }

    public int? AmbienceId { get; set; }

    public int EffectType { get; set; }

    public float TransitionSkyBox { get; set; }

    public float EffectColor1 { get; set; }

    public float EffectColor2 { get; set; }

    public float EffectColor3 { get; set; }

    public string? EffectTexture { get; set; }

    public virtual Soundentry? Ambience { get; set; }
}
