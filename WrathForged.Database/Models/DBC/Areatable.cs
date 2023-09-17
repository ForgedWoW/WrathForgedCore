// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AreaTable.dbc")]
public partial class Areatable
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT, Nullable = true)]
    public int? ContinentId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT, Nullable = true)]
    public int? ParentAreaId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT)]
    public int AreaBit { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT)]
    public int Flags { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT, Nullable = true)]
    public int? SoundProviderPref { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT, Nullable = true)]
    public int? SoundProviderPrefUnderwater { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT, Nullable = true)]
    public int? AmbienceId { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT, Nullable = true)]
    public int? ZoneMusic { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT, Nullable = true)]
    public int? IntroSound { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT)]
    public int ExplorationLevel { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? AreaNameLangEnUs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? AreaNameLangEnGb { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? AreaNameLangKoKr { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? AreaNameLangFrFr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? AreaNameLangDeDe { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? AreaNameLangEnCn { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? AreaNameLangZhCn { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? AreaNameLangEnTw { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? AreaNameLangZhTw { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? AreaNameLangEsEs { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? AreaNameLangEsMx { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? AreaNameLangRuRu { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? AreaNameLangPtPt { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? AreaNameLangPtBr { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? AreaNameLangItIt { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? AreaNameLangUnk { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT)]
    public uint AreaNameLangMask { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public int FactionGroupMask { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT, Nullable = true)]
    public int? LiquidTypeId1 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT, Nullable = true)]
    public int? LiquidTypeId2 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT, Nullable = true)]
    public int? LiquidTypeId3 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT, Nullable = true)]
    public int? LiquidTypeId4 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
    public float MinElevation { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.FLOAT)]
    public float AmbientMultiplier { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT, Nullable = true)]
    public int? Lightid { get; set; }

    public virtual Soundambience? Ambience { get; set; }

    public virtual ICollection<Areagroup> AreagroupAreaId1Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areagroup> AreagroupAreaId2Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areagroup> AreagroupAreaId3Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areagroup> AreagroupAreaId4Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areagroup> AreagroupAreaId5Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areagroup> AreagroupAreaId6Navigations { get; set; } = new List<Areagroup>();

    public virtual ICollection<Areapoi> Areapois { get; set; } = new List<Areapoi>();

    public virtual Map? Continent { get; set; }

    public virtual Zoneintromusictable? IntroSoundNavigation { get; set; }

    public virtual ICollection<Areatable> InverseParentArea { get; set; } = new List<Areatable>();

    public virtual Light? Light { get; set; }

    public virtual Liquidtype? LiquidTypeId1Navigation { get; set; }

    public virtual Liquidtype? LiquidTypeId2Navigation { get; set; }

    public virtual Liquidtype? LiquidTypeId3Navigation { get; set; }

    public virtual Liquidtype? LiquidTypeId4Navigation { get; set; }

    public virtual ICollection<Map> Maps { get; set; } = new List<Map>();

    public virtual Areatable? ParentArea { get; set; }

    public virtual Soundproviderpreference? SoundProviderPrefNavigation { get; set; }

    public virtual Soundproviderpreference? SoundProviderPrefUnderwaterNavigation { get; set; }

    public virtual ICollection<Wmoareatable> Wmoareatables { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldmaparea> Worldmapareas { get; set; } = new List<Worldmaparea>();

    public virtual ICollection<Worldmapoverlay> WorldmapoverlayAreaId1Navigations { get; set; } = new List<Worldmapoverlay>();

    public virtual ICollection<Worldmapoverlay> WorldmapoverlayAreaId2Navigations { get; set; } = new List<Worldmapoverlay>();

    public virtual ICollection<Worldmapoverlay> WorldmapoverlayAreaId3Navigations { get; set; } = new List<Worldmapoverlay>();

    public virtual ICollection<Worldmapoverlay> WorldmapoverlayAreaId4Navigations { get; set; } = new List<Worldmapoverlay>();

    public virtual ICollection<Worldstateui> Worldstateuis { get; set; } = new List<Worldstateui>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();

    public virtual Zonemusic? ZoneMusicNavigation { get; set; }
}