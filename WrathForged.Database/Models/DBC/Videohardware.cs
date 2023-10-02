// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("VideoHardware.dbc")]
    public partial class Videohardware : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int VendorId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int DeviceId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int FarclipIdx { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int TerrainLoddistIdx { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int TerrainShadowLod { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int DetailDoodadDensityIdx { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int DetailDoodadAlpha { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int AnimatingDoodadIdx { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int Trilinear { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int NumLights { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int Specularity { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int WaterLodidx { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int ParticleDensityIdx { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int UnitDrawDistIdx { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int SmallCullDistIdx { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int ResolutionIdx { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int BaseMipLevel { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
        public string? OglOverrides { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
        public string? D3dOverrides { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32)]
        public int FixLag { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int Multisample { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
        public int Atlasdisable { get; set; }
    }
}
