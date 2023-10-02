// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellRuneCost.dbc")]
    public partial class Spellrunecost : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Blood { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Unholy { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Frost { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int RunicPower { get; set; }

        public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
    }
}
