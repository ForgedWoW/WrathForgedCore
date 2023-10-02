// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellMissile.dbc")]
    public partial class Spellmissile : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
        public float DefaultPitchMin { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
        public float DefaultPitchMax { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float DefaultSpeedMin { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float DefaultSpeedMax { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float RandomizeFacingMin { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float RandomizeFacingMax { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
        public float RandomizePitchMin { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
        public float RandomizePitchMax { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
        public float RandomizeSpeedMin { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
        public float RandomizeSpeedMax { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
        public float Gravity { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
        public float MaxDuration { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
        public float CollisionRadius { get; set; }

        public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
    }
}
