// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SkillCostsData.dbc")]
    public partial class Skillcostsdatum : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int SkillCostsId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Cost1 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Cost2 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int Cost3 { get; set; }

        public virtual ICollection<Skillline> Skilllines { get; set; } = new List<Skillline>();

        public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();
    }
}
