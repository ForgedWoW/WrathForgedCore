// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("GemProperties.dbc")]
public partial class Gemproperty : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? EnchantId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int MaxcountInv { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int MaxcountItem { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Type { get; set; }

    public virtual Spellitemenchantment? Enchant { get; set; }
}
