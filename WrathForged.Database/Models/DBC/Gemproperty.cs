using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gemproperty
{
    public int Id { get; set; }

    public int? EnchantId { get; set; }

    public int MaxcountInv { get; set; }

    public int MaxcountItem { get; set; }

    public int Type { get; set; }

    public virtual Spellitemenchantment? Enchant { get; set; }
}
