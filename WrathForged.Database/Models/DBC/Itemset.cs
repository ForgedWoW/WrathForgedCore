// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ItemSet.dbc")]
public partial class Itemset : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int? ItemId1 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int? ItemId2 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int? ItemId3 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int? ItemId4 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int? ItemId5 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int? ItemId6 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int? ItemId7 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int? ItemId8 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int? ItemId9 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int? ItemId10 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int? ItemId11 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int? ItemId12 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int? ItemId13 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32)]
    public int? ItemId14 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int? ItemId15 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32)]
    public int? ItemId16 { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32)]
    public int? ItemId17 { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT32)]
    public int? SetSpellId1 { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32)]
    public int? SetSpellId2 { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int? SetSpellId3 { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32)]
    public int? SetSpellId4 { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.INT32)]
    public int? SetSpellId5 { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.INT32)]
    public int? SetSpellId6 { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.INT32)]
    public int? SetSpellId7 { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.INT32)]
    public int? SetSpellId8 { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.INT32)]
    public int SetThreshold1 { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.INT32)]
    public int SetThreshold2 { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.INT32)]
    public int SetThreshold3 { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.INT32)]
    public int SetThreshold4 { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.INT32)]
    public int SetThreshold5 { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.INT32)]
    public int SetThreshold6 { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.INT32)]
    public int SetThreshold7 { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.INT32)]
    public int SetThreshold8 { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.INT32)]
    public int? RequiredSkill { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.INT32)]
    public int RequiredSkillRank { get; set; }

    public virtual Item? ItemId10Navigation { get; set; }

    public virtual Item? ItemId11Navigation { get; set; }

    public virtual Item? ItemId12Navigation { get; set; }

    public virtual Item? ItemId13Navigation { get; set; }

    public virtual Item? ItemId14Navigation { get; set; }

    public virtual Item? ItemId15Navigation { get; set; }

    public virtual Item? ItemId16Navigation { get; set; }

    public virtual Item? ItemId17Navigation { get; set; }

    public virtual Item? ItemId1Navigation { get; set; }

    public virtual Item? ItemId2Navigation { get; set; }

    public virtual Item? ItemId3Navigation { get; set; }

    public virtual Item? ItemId4Navigation { get; set; }

    public virtual Item? ItemId5Navigation { get; set; }

    public virtual Item? ItemId6Navigation { get; set; }

    public virtual Item? ItemId7Navigation { get; set; }

    public virtual Item? ItemId8Navigation { get; set; }

    public virtual Item? ItemId9Navigation { get; set; }

    public virtual Skillline? RequiredSkillNavigation { get; set; }

    public virtual Spell? SetSpellId1Navigation { get; set; }

    public virtual Spell? SetSpellId2Navigation { get; set; }

    public virtual Spell? SetSpellId3Navigation { get; set; }

    public virtual Spell? SetSpellId4Navigation { get; set; }

    public virtual Spell? SetSpellId5Navigation { get; set; }

    public virtual Spell? SetSpellId6Navigation { get; set; }

    public virtual Spell? SetSpellId7Navigation { get; set; }

    public virtual Spell? SetSpellId8Navigation { get; set; }
}