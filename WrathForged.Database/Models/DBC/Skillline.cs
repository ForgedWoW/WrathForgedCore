// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SkillLine.dbc")]
public partial class Skillline : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? CategoryId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int? SkillCostsId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? DisplayNameLangEnUs { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? DisplayNameLangEnGb { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? DisplayNameLangKoKr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? DisplayNameLangFrFr { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? DisplayNameLangDeDe { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? DisplayNameLangEnCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? DisplayNameLangZhCn { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? DisplayNameLangEnTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? DisplayNameLangZhTw { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? DisplayNameLangEsEs { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? DisplayNameLangEsMx { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? DisplayNameLangRuRu { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? DisplayNameLangPtPt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? DisplayNameLangPtBr { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? DisplayNameLangItIt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? DisplayNameLangUnk { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.UINT32)]
    public uint DisplayNameLangMask { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.UINT32)]
    public uint DescriptionLangMask { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int? SpellIconId { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? AlternateVerbLangEnUs { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.STRING)]
    public string? AlternateVerbLangEnGb { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? AlternateVerbLangKoKr { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? AlternateVerbLangFrFr { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? AlternateVerbLangDeDe { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? AlternateVerbLangEnCn { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? AlternateVerbLangZhCn { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? AlternateVerbLangEnTw { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? AlternateVerbLangZhTw { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING)]
    public string? AlternateVerbLangEsEs { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? AlternateVerbLangEsMx { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? AlternateVerbLangRuRu { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? AlternateVerbLangPtPt { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING)]
    public string? AlternateVerbLangPtBr { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING)]
    public string? AlternateVerbLangItIt { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING)]
    public string? AlternateVerbLangUnk { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.UINT32)]
    public uint AlternateVerbLangMask { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.INT32)]
    public int CanLink { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.INT32)]
    public int Unknown { get; set; }

    public virtual Skilllinecategory? Category { get; set; }

    public virtual ICollection<Creaturefamily> CreaturefamilySkillLine1Navigations { get; set; } = new List<Creaturefamily>();

    public virtual ICollection<Creaturefamily> CreaturefamilySkillLine2Navigations { get; set; } = new List<Creaturefamily>();

    public virtual ICollection<Itemset> Itemsets { get; set; } = new List<Itemset>();

    public virtual Skillcostsdatum? SkillCosts { get; set; }

    public virtual ICollection<Skilllineability> Skilllineabilities { get; set; } = new List<Skilllineability>();

    public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();

    public virtual Spellicon? SpellIcon { get; set; }

    public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
}
