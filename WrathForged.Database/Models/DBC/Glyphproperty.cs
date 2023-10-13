// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("GlyphProperties.dbc")]
public partial class Glyphproperty : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? SpellId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int GlyphSlotFlags { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? SpellIconId { get; set; }

    public virtual Spell? Spell { get; set; }
    public virtual Spellicon? SpellIcon { get; set; }
}
