using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Liquidtype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Flags { get; set; }

    public int Type { get; set; }

    public int SoundId { get; set; }

    public int SpellId { get; set; }

    public float MaxDarkenDepth { get; set; }

    public float FogDarkenintensity { get; set; }

    public float AmbDarkenintensity { get; set; }

    public float DirDarkenintensity { get; set; }

    public int LightId { get; set; }

    public float ParticleScale { get; set; }

    public int ParticleMovement { get; set; }

    public int ParticleTexSlots { get; set; }

    public int MaterialId { get; set; }

    public string? Texture1 { get; set; }

    public string? Texture2 { get; set; }

    public string? Texture3 { get; set; }

    public string? Texture4 { get; set; }

    public string? Texture5 { get; set; }

    public string? Texture6 { get; set; }

    public int Color1 { get; set; }

    public int Color2 { get; set; }

    public float Float1 { get; set; }

    public float Float2 { get; set; }

    public float Float3 { get; set; }

    public float Float4 { get; set; }

    public float Float5 { get; set; }

    public float Float6 { get; set; }

    public float Float7 { get; set; }

    public float Float8 { get; set; }

    public float Float9 { get; set; }

    public float Float10 { get; set; }

    public float Float11 { get; set; }

    public float Float12 { get; set; }

    public float Float13 { get; set; }

    public float Float14 { get; set; }

    public float Float15 { get; set; }

    public float Float16 { get; set; }

    public float Float17 { get; set; }

    public float Float18 { get; set; }

    public int Int1 { get; set; }

    public int Int2 { get; set; }

    public int Int3 { get; set; }

    public int Int4 { get; set; }

    public virtual ICollection<Areatable> AreatableLiquidTypeId1Navigations { get; set; } = new List<Areatable>();

    public virtual ICollection<Areatable> AreatableLiquidTypeId2Navigations { get; set; } = new List<Areatable>();

    public virtual ICollection<Areatable> AreatableLiquidTypeId3Navigations { get; set; } = new List<Areatable>();

    public virtual ICollection<Areatable> AreatableLiquidTypeId4Navigations { get; set; } = new List<Areatable>();
}
