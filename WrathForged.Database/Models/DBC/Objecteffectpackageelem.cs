// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ObjectEffectPackageElem.dbc")]
    public partial class Objecteffectpackageelem : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? ObjectEffectPackageId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? ObjectEffectGroupId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int StateType { get; set; }

        public virtual Objecteffectgroup? ObjectEffectGroup { get; set; }
        public virtual Objecteffectpackage? ObjectEffectPackage { get; set; }
    }
}
