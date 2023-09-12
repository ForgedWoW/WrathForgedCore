using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellicon
{
    public int Id { get; set; }

    public string? TextureFilename { get; set; }

    public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

    public virtual ICollection<Glyphproperty> Glyphproperties { get; set; } = new List<Glyphproperty>();

    public virtual ICollection<Skillline> Skilllines { get; set; } = new List<Skillline>();

    public virtual ICollection<Spell> SpellActiveIcons { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellSpellIcons { get; set; } = new List<Spell>();

    public virtual ICollection<Spellshapeshiftform> Spellshapeshiftforms { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Talenttab> Talenttabs { get; set; } = new List<Talenttab>();
}
