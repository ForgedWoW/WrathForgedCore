using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellshapeshiftform
{
    public int Id { get; set; }

    public int BonusActionBar { get; set; }

    public string? NameLangEnUs { get; set; }

    public string? NameLangEnGb { get; set; }

    public string? NameLangKoKr { get; set; }

    public string? NameLangFrFr { get; set; }

    public string? NameLangDeDe { get; set; }

    public string? NameLangEnCn { get; set; }

    public string? NameLangZhCn { get; set; }

    public string? NameLangEnTw { get; set; }

    public string? NameLangZhTw { get; set; }

    public string? NameLangEsEs { get; set; }

    public string? NameLangEsMx { get; set; }

    public string? NameLangRuRu { get; set; }

    public string? NameLangPtPt { get; set; }

    public string? NameLangPtBr { get; set; }

    public string? NameLangItIt { get; set; }

    public string? NameLangUnk { get; set; }

    public uint NameLangMask { get; set; }

    public int Flags { get; set; }

    public int? CreatureType { get; set; }

    public int? AttackIconId { get; set; }

    public int CombatRoundTime { get; set; }

    public int? CreatureDisplayId1 { get; set; }

    public int? CreatureDisplayId2 { get; set; }

    public int? CreatureDisplayId3 { get; set; }

    public int? CreatureDisplayId4 { get; set; }

    public int? PresetSpellId1 { get; set; }

    public int? PresetSpellId2 { get; set; }

    public int? PresetSpellId3 { get; set; }

    public int? PresetSpellId4 { get; set; }

    public int? PresetSpellId5 { get; set; }

    public int? PresetSpellId6 { get; set; }

    public int? PresetSpellId7 { get; set; }

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
