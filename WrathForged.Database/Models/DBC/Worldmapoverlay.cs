// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("WorldMapOverlay.dbc")]
    public partial class Worldmapoverlay : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? MapAreaId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? AreaId1 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? AreaId2 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? AreaId3 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? AreaId4 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int MapPointX { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int MapPointY { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? TextureName { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int TextureWidth { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int TextureHeight { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int OffsetX { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int OffsetY { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int HitRectTop { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int HitRectLeft { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int HitRectBottom { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int HitRectRight { get; set; }

        public virtual Areatable? AreaId1Navigation { get; set; }
        public virtual Areatable? AreaId2Navigation { get; set; }
        public virtual Areatable? AreaId3Navigation { get; set; }
        public virtual Areatable? AreaId4Navigation { get; set; }
        public virtual Worldmaparea? MapArea { get; set; }
    }
}
