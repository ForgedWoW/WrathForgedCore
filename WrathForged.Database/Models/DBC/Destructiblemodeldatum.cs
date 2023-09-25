// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("DestructibleModelData.dbc")]
    public partial class Destructiblemodeldatum : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int State0Wmo { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int State0DestructionDoodadSet { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int State0ImpactEffectDoodadSet { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int State0AmbientDoodadSet { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int State1Wmo { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int State1DestructionDoodadSet { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int State1ImpactEffectDoodadSet { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int State1AmbientDoodadSet { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int State2Wmo { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int State2DestructionDoodadSet { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int State2ImpactEffectDoodadSet { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int State2AmbientDoodadSet { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int State3Wmo { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int State3DestructionDoodadSet { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int State3ImpactEffectDoodadSet { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int State3AmbientDoodadSet { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int Field17 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int Field18 { get; set; }
    }
}
