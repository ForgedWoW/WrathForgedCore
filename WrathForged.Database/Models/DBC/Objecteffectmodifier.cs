// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ObjectEffectModifier.dbc")]
    public partial class Objecteffectmodifier : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int InputType { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int MapType { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int OutputType { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float Param1 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float Param2 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float Param3 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float Param4 { get; set; }

        // Virtual collections and references are not annotated with DBCPropertyBinding
        public virtual ICollection<Objecteffect> Objecteffects { get; set; } = new List<Objecteffect>();
    }
}
