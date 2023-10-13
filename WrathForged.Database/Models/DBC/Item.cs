// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Item.dbc")]
public partial class Item : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? ClassId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int? SubclassId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int SoundOverrideSubclassid { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int? Material { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int? DisplayInfoId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int InventoryType { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int SheatheType { get; set; }

    public virtual Itemclass? Class { get; set; }

    public virtual Itemdisplayinfo? DisplayInfo { get; set; }

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId1Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId2Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId3Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId4Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId5Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId6Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId7Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itempurchasegroup> ItempurchasegroupItemId8Navigations { get; set; } = new List<Itempurchasegroup>();

    public virtual ICollection<Itemset> ItemsetItemId10Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId11Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId12Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId13Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId14Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId15Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId16Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId17Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId1Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId2Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId3Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId4Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId5Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId6Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId7Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId8Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetItemId9Navigations { get; set; } = new List<Itemset>();

    public virtual Material? MaterialNavigation { get; set; }

    public virtual ICollection<Spell> SpellReagent1Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent2Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent3Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent4Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent5Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent6Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent7Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellReagent8Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();

    public virtual ICollection<Stationery> Stationeries { get; set; } = new List<Stationery>();

    public virtual Itemsubclass? Subclass { get; set; }
}