using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemset
{
    public int Id { get; set; }

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

    public int? ItemId1 { get; set; }

    public int? ItemId2 { get; set; }

    public int? ItemId3 { get; set; }

    public int? ItemId4 { get; set; }

    public int? ItemId5 { get; set; }

    public int? ItemId6 { get; set; }

    public int? ItemId7 { get; set; }

    public int? ItemId8 { get; set; }

    public int? ItemId9 { get; set; }

    public int? ItemId10 { get; set; }

    public int? ItemId11 { get; set; }

    public int? ItemId12 { get; set; }

    public int? ItemId13 { get; set; }

    public int? ItemId14 { get; set; }

    public int? ItemId15 { get; set; }

    public int? ItemId16 { get; set; }

    public int? ItemId17 { get; set; }

    public int? SetSpellId1 { get; set; }

    public int? SetSpellId2 { get; set; }

    public int? SetSpellId3 { get; set; }

    public int? SetSpellId4 { get; set; }

    public int? SetSpellId5 { get; set; }

    public int? SetSpellId6 { get; set; }

    public int? SetSpellId7 { get; set; }

    public int? SetSpellId8 { get; set; }

    public int SetThreshold1 { get; set; }

    public int SetThreshold2 { get; set; }

    public int SetThreshold3 { get; set; }

    public int SetThreshold4 { get; set; }

    public int SetThreshold5 { get; set; }

    public int SetThreshold6 { get; set; }

    public int SetThreshold7 { get; set; }

    public int SetThreshold8 { get; set; }

    public int? RequiredSkill { get; set; }

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
