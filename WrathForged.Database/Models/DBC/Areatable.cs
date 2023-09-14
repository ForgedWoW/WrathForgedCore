// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.DBC;

public partial class Areatable
{
    public int Id { get; set; }

    public int? ContinentId { get; set; }

    public int? ParentAreaId { get; set; }

    public int AreaBit { get; set; }

    public int Flags { get; set; }

    public int? SoundProviderPref { get; set; }

    public int? SoundProviderPrefUnderwater { get; set; }

    public int? AmbienceId { get; set; }

    public int? ZoneMusic { get; set; }

    public int? IntroSound { get; set; }

    public int ExplorationLevel { get; set; }

    public string? AreaNameLangEnUs { get; set; }

    public string? AreaNameLangEnGb { get; set; }

    public string? AreaNameLangKoKr { get; set; }

    public string? AreaNameLangFrFr { get; set; }

    public string? AreaNameLangDeDe { get; set; }

    public string? AreaNameLangEnCn { get; set; }

    public string? AreaNameLangZhCn { get; set; }

    public string? AreaNameLangEnTw { get; set; }

    public string? AreaNameLangZhTw { get; set; }

    public string? AreaNameLangEsEs { get; set; }

    public string? AreaNameLangEsMx { get; set; }

    public string? AreaNameLangRuRu { get; set; }

    public string? AreaNameLangPtPt { get; set; }

    public string? AreaNameLangPtBr { get; set; }

    public string? AreaNameLangItIt { get; set; }

    public string? AreaNameLangUnk { get; set; }

    public uint AreaNameLangMask { get; set; }

    public int FactionGroupMask { get; set; }

    public int? LiquidTypeId1 { get; set; }

    public int? LiquidTypeId2 { get; set; }

    public int? LiquidTypeId3 { get; set; }

    public int? LiquidTypeId4 { get; set; }

    public float MinElevation { get; set; }

    public float AmbientMultiplier { get; set; }

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