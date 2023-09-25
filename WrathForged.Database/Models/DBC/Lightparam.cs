// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("LightParams.dbc")]
    public partial class Lightparam : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int HighlightSky { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int? LightSkyboxId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int CloudTypeId { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float Glow { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float WaterShallowAlpha { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float WaterDeepAlpha { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float OceanShallowAlpha { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
        public float OceanDeepAlpha { get; set; }

        public virtual Lightskybox? LightSkybox { get; set; }
    }
}
