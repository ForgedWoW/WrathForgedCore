// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("UnitBlood.dbc")]
    public partial class Unitblood : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int CombatBloodSpurtFront1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int CombatBloodSpurtFront2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int CombatBloodSpurtBack1 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int CombatBloodSpurtBack2 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? GroundBlood1 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? GroundBlood2 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? GroundBlood3 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? GroundBlood4 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? GroundBlood5 { get; set; }

        public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
    }
}
