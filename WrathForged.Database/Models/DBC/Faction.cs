using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Faction
{
    public int Id { get; set; }

    public int ReputationIndex { get; set; }

    public int ReputationRaceMask1 { get; set; }

    public int ReputationRaceMask2 { get; set; }

    public int ReputationRaceMask3 { get; set; }

    public int ReputationRaceMask4 { get; set; }

    public int ReputationClassMask1 { get; set; }

    public int ReputationClassMask2 { get; set; }

    public int ReputationClassMask3 { get; set; }

    public int ReputationClassMask4 { get; set; }

    public int ReputationBase1 { get; set; }

    public int ReputationBase2 { get; set; }

    public int ReputationBase3 { get; set; }

    public int ReputationBase4 { get; set; }

    public int ReputationFlags1 { get; set; }

    public int ReputationFlags2 { get; set; }

    public int ReputationFlags3 { get; set; }

    public int ReputationFlags4 { get; set; }

    public int? ParentFactionId { get; set; }

    public float ParentFactionMod1 { get; set; }

    public float ParentFactionMod2 { get; set; }

    public int ParentFactionCap1 { get; set; }

    public int ParentFactionCap2 { get; set; }

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

    public string? DescriptionLangEnUs { get; set; }

    public string? DescriptionLangEnGb { get; set; }

    public string? DescriptionLangKoKr { get; set; }

    public string? DescriptionLangFrFr { get; set; }

    public string? DescriptionLangDeDe { get; set; }

    public string? DescriptionLangEnCn { get; set; }

    public string? DescriptionLangZhCn { get; set; }

    public string? DescriptionLangEnTw { get; set; }

    public string? DescriptionLangZhTw { get; set; }

    public string? DescriptionLangEsEs { get; set; }

    public string? DescriptionLangEsMx { get; set; }

    public string? DescriptionLangRuRu { get; set; }

    public string? DescriptionLangPtPt { get; set; }

    public string? DescriptionLangPtBr { get; set; }

    public string? DescriptionLangItIt { get; set; }

    public string? DescriptionLangUnk { get; set; }

    public uint DescriptionLangMask { get; set; }

    public virtual ICollection<Areapoi> Areapois { get; set; } = new List<Areapoi>();

    public virtual ICollection<Auctionhouse> Auctionhouses { get; set; } = new List<Auctionhouse>();

    public virtual ICollection<Factiontemplate> FactiontemplateEnemies1Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateEnemies2Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateEnemies3Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateEnemies4Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateFactionNavigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateFriend1Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateFriend2Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateFriend3Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Factiontemplate> FactiontemplateFriend4Navigations { get; set; } = new List<Factiontemplate>();

    public virtual ICollection<Faction> InverseParentFaction { get; set; } = new List<Faction>();

    public virtual ICollection<Lfgdungeon> Lfgdungeons { get; set; } = new List<Lfgdungeon>();

    public virtual Faction? ParentFaction { get; set; }
}
