// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Material.dbc")]
    public partial class Material : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? FoleySoundId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? SheatheSoundId { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? UnsheatheSoundId { get; set; }

        // Virtual collections and references are not annotated with DBCPropertyBinding
        public virtual Soundentry? FoleySound { get; set; }
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
        public virtual Soundentry? SheatheSound { get; set; }
        public virtual Soundentry? UnsheatheSound { get; set; }
    }
}
