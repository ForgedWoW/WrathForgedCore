using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Glyphproperty
{
    public int Id { get; set; }

    public int? SpellId { get; set; }

    public int GlyphSlotFlags { get; set; }

    public int? SpellIconId { get; set; }

    public virtual Spell? Spell { get; set; }

    public virtual Spellicon? SpellIcon { get; set; }
}
