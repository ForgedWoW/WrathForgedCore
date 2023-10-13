// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Faction.dbc")]
public partial class Faction : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int ReputationIndex { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int ReputationRaceMask1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int ReputationRaceMask2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int ReputationRaceMask3 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int ReputationRaceMask4 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int ReputationClassMask1 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int ReputationClassMask2 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int ReputationClassMask3 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int ReputationClassMask4 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int ReputationBase1 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int ReputationBase2 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int ReputationBase3 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int ReputationBase4 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int ReputationFlags1 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int ReputationFlags2 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int ReputationFlags3 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int ReputationFlags4 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
    public int? ParentFactionId { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float ParentFactionMod1 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float ParentFactionMod2 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int ParentFactionCap1 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int ParentFactionCap2 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING, Nullable = true)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.STRING, Nullable = true)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.UINT32)]
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
