// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellShapeshiftForm.dbc")]
public partial class Spellshapeshiftform : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int BonusActionBar { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureType { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32, Nullable = true)]
    public int? AttackIconId { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int CombatRoundTime { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureDisplayId1 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureDisplayId2 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureDisplayId3 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureDisplayId4 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId1 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId2 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId3 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId4 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId5 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId6 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId7 { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32, Nullable = true)]
    public int? PresetSpellId8 { get; set; }

    public virtual Spellicon? AttackIcon { get; set; }

    public virtual Creaturedisplayinfo? CreatureDisplayId1Navigation { get; set; }

    public virtual Creaturedisplayinfo? CreatureDisplayId2Navigation { get; set; }

    public virtual Creaturedisplayinfo? CreatureDisplayId3Navigation { get; set; }

    public virtual Creaturedisplayinfo? CreatureDisplayId4Navigation { get; set; }

    public virtual Creaturetype? CreatureTypeNavigation { get; set; }

    public virtual Spell? PresetSpellId1Navigation { get; set; }

    public virtual Spell? PresetSpellId2Navigation { get; set; }

    public virtual Spell? PresetSpellId3Navigation { get; set; }

    public virtual Spell? PresetSpellId4Navigation { get; set; }

    public virtual Spell? PresetSpellId5Navigation { get; set; }

    public virtual Spell? PresetSpellId6Navigation { get; set; }

    public virtual Spell? PresetSpellId7Navigation { get; set; }

    public virtual Spell? PresetSpellId8Navigation { get; set; }
}