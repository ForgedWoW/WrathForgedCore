using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemvisual
{
    public int Id { get; set; }

    public int? Slot1 { get; set; }

    public int? Slot2 { get; set; }

    public int? Slot3 { get; set; }

    public int? Slot4 { get; set; }

    public int? Slot5 { get; set; }

    public virtual ICollection<Itemdisplayinfo> Itemdisplayinfos { get; set; } = new List<Itemdisplayinfo>();

    public virtual Itemvisualeffect? Slot1Navigation { get; set; }

    public virtual Itemvisualeffect? Slot2Navigation { get; set; }

    public virtual Itemvisualeffect? Slot3Navigation { get; set; }

    public virtual Itemvisualeffect? Slot4Navigation { get; set; }

    public virtual Itemvisualeffect? Slot5Navigation { get; set; }

    public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
}
