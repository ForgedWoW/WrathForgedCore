// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
