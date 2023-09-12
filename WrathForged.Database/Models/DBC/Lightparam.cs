using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Lightparam
{
    public int Id { get; set; }

    public int HighlightSky { get; set; }

    public int? LightSkyboxId { get; set; }

    public int CloudTypeId { get; set; }

    public float Glow { get; set; }

    public float WaterShallowAlpha { get; set; }

    public float WaterDeepAlpha { get; set; }

    public float OceanShallowAlpha { get; set; }

    public float OceanDeepAlpha { get; set; }

    public virtual Lightskybox? LightSkybox { get; set; }
}
