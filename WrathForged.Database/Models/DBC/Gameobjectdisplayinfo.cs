// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("GameObjectDisplayInfo.dbc")]
    public partial class Gameobjectdisplayinfo : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? ModelName { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? Sound1 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? Sound2 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? Sound3 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? Sound4 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? Sound5 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? Sound6 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? Sound7 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? Sound8 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? Sound9 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? Sound10 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
        public float GeoBoxMinX { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
        public float GeoBoxMinY { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
        public float GeoBoxMinZ { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
        public float GeoBoxMaxX { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
        public float GeoBoxMaxY { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
        public float GeoBoxMaxZ { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
        public int? ObjectEffectPackageId { get; set; }

        public virtual Objecteffectpackage? ObjectEffectPackage { get; set; }
        public virtual Soundentry? Sound10Navigation { get; set; }
        public virtual Soundentry? Sound1Navigation { get; set; }
        public virtual Soundentry? Sound2Navigation { get; set; }
        public virtual Soundentry? Sound3Navigation { get; set; }
        public virtual Soundentry? Sound4Navigation { get; set; }
        public virtual Soundentry? Sound5Navigation { get; set; }
        public virtual Soundentry? Sound6Navigation { get; set; }
        public virtual Soundentry? Sound7Navigation { get; set; }
        public virtual Soundentry? Sound8Navigation { get; set; }
        public virtual Soundentry? Sound9Navigation { get; set; }
    }
}
