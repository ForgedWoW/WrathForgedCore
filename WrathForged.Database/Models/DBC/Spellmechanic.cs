using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellmechanic
{
    public int Id { get; set; }

    public string? StateNameLangEnUs { get; set; }

    public string? StateNameLangEnGb { get; set; }

    public string? StateNameLangKoKr { get; set; }

    public string? StateNameLangFrFr { get; set; }

    public string? StateNameLangDeDe { get; set; }

    public string? StateNameLangEnCn { get; set; }

    public string? StateNameLangZhCn { get; set; }

    public string? StateNameLangEnTw { get; set; }

    public string? StateNameLangZhTw { get; set; }

    public string? StateNameLangEsEs { get; set; }

    public string? StateNameLangEsMx { get; set; }

    public string? StateNameLangRuRu { get; set; }

    public string? StateNameLangPtPt { get; set; }

    public string? StateNameLangPtBr { get; set; }

    public string? StateNameLangItIt { get; set; }

    public string? StateNameLangUnk { get; set; }

    public uint StateNameLangMask { get; set; }

    public virtual ICollection<Spell> SpellEffectMechanic1Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellEffectMechanic2Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellEffectMechanic3Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellMechanicNavigations { get; set; } = new List<Spell>();
}
