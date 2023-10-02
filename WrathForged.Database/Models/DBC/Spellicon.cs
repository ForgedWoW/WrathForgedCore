// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellIcon.dbc")]
    public partial class Spellicon : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? TextureFilename { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();
        public virtual ICollection<Glyphproperty> Glyphproperties { get; set; } = new List<Glyphproperty>();
        public virtual ICollection<Skillline> Skilllines { get; set; } = new List<Skillline>();
        public virtual ICollection<Spell> SpellActiveIcons { get; set; } = new List<Spell>();
        public virtual ICollection<Spell> SpellSpellIcons { get; set; } = new List<Spell>();
        public virtual ICollection<Spellshapeshiftform> Spellshapeshiftforms { get; set; } = new List<Spellshapeshiftform>();
        public virtual ICollection<Talenttab> Talenttabs { get; set; } = new List<Talenttab>();
    }
}
