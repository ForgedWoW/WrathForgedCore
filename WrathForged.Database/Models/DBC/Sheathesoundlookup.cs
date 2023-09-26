// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SheatheSoundLookups.dbc")]
    public partial class Sheathesoundlookup : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int? ItemClass { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int? ItemSubclass { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int ItemEnvTypes { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int IsShield { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int? SheathSoundId { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int? UnsheathSoundId { get; set; }

        public virtual Itemsubclass? ItemClassNavigation { get; set; }

        public virtual Itemsubclass? ItemSubclassNavigation { get; set; }

        public virtual Soundentry? SheathSound { get; set; }

        public virtual Soundentry? UnsheathSound { get; set; }
    }
}
