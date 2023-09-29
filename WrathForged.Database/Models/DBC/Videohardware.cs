// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Videohardware
{
    public int Id { get; set; }

    public int VendorId { get; set; }

    public int DeviceId { get; set; }

    public int FarclipIdx { get; set; }

    public int TerrainLoddistIdx { get; set; }

    public int TerrainShadowLod { get; set; }

    public int DetailDoodadDensityIdx { get; set; }

    public int DetailDoodadAlpha { get; set; }

    public int AnimatingDoodadIdx { get; set; }

    public int Trilinear { get; set; }

    public int NumLights { get; set; }

    public int Specularity { get; set; }

    public int WaterLodidx { get; set; }

    public int ParticleDensityIdx { get; set; }

    public int UnitDrawDistIdx { get; set; }

    public int SmallCullDistIdx { get; set; }

    public int ResolutionIdx { get; set; }

    public int BaseMipLevel { get; set; }

    public string? OglOverrides { get; set; }

    public string? D3dOverrides { get; set; }

    public int FixLag { get; set; }

    public int Multisample { get; set; }

    public int Atlasdisable { get; set; }
}
