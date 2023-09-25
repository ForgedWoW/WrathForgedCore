// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Emotes.dbc")]
    public partial class Emote : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? EmoteSlashCommand { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? AnimId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int EmoteFlags { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int EmoteSpecProc { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int EmoteSpecProcParam { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? EventSoundId { get; set; }

        public virtual Animationdatum? Anim { get; set; }
        public virtual ICollection<Emotestext> Emotestexts { get; set; } = new List<Emotestext>();
        public virtual Soundentry? EventSound { get; set; }
    }
}
