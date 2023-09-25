// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("GroundEffectTexture.dbc")]
    public partial class Groundeffecttexture : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? DoodadId1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? DoodadId2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? DoodadId3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? DoodadId4 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int DoodadWeight1 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int DoodadWeight2 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int DoodadWeight3 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int DoodadWeight4 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int Density { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int Sound { get; set; }

        public virtual Groundeffectdoodad? DoodadId1Navigation { get; set; }
        public virtual Groundeffectdoodad? DoodadId2Navigation { get; set; }
        public virtual Groundeffectdoodad? DoodadId3Navigation { get; set; }
        public virtual Groundeffectdoodad? DoodadId4Navigation { get; set; }
    }
}
