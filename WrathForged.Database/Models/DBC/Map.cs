using System;
using System.Collections.Generic;
using WrathForged.Database.Models.DBC;

namespace WrathForged.Database.Models.DBC;

public partial class Map
{
    public int Id { get; set; }

    public string? Directory { get; set; }

    public int InstanceType { get; set; }

    public int Flags { get; set; }

    public int Pvp { get; set; }

    public string? MapNameLangEnUs { get; set; }

    public string? MapNameLangEnGb { get; set; }

    public string? MapNameLangKoKr { get; set; }

    public string? MapNameLangFrFr { get; set; }

    public string? MapNameLangDeDe { get; set; }

    public string? MapNameLangEnCn { get; set; }

    public string? MapNameLangZhCn { get; set; }

    public string? MapNameLangEnTw { get; set; }

    public string? MapNameLangZhTw { get; set; }

    public string? MapNameLangEsEs { get; set; }

    public string? MapNameLangEsMx { get; set; }

    public string? MapNameLangRuRu { get; set; }

    public string? MapNameLangPtPt { get; set; }

    public string? MapNameLangPtBr { get; set; }

    public string? MapNameLangItIt { get; set; }

    public string? MapNameLangUnk { get; set; }

    public uint MapNameLangMask { get; set; }

    public int? AreaTableId { get; set; }

    public string? MapDescription0LangEnUs { get; set; }

    public string? MapDescription0LangEnGb { get; set; }

    public string? MapDescription0LangKoKr { get; set; }

    public string? MapDescription0LangFrFr { get; set; }

    public string? MapDescription0LangDeDe { get; set; }

    public string? MapDescription0LangEnCn { get; set; }

    public string? MapDescription0LangZhCn { get; set; }

    public string? MapDescription0LangEnTw { get; set; }

    public string? MapDescription0LangZhTw { get; set; }

    public string? MapDescription0LangEsEs { get; set; }

    public string? MapDescription0LangEsMx { get; set; }

    public string? MapDescription0LangRuRu { get; set; }

    public string? MapDescription0LangPtPt { get; set; }

    public string? MapDescription0LangPtBr { get; set; }

    public string? MapDescription0LangItIt { get; set; }

    public string? MapDescription0LangUnk { get; set; }

    public uint MapDescription0LangMask { get; set; }

    public string? MapDescription1LangEnUs { get; set; }

    public string? MapDescription1LangEnGb { get; set; }

    public string? MapDescription1LangKoKr { get; set; }

    public string? MapDescription1LangFrFr { get; set; }

    public string? MapDescription1LangDeDe { get; set; }

    public string? MapDescription1LangEnCn { get; set; }

    public string? MapDescription1LangZhCn { get; set; }

    public string? MapDescription1LangEnTw { get; set; }

    public string? MapDescription1LangZhTw { get; set; }

    public string? MapDescription1LangEsEs { get; set; }

    public string? MapDescription1LangEsMx { get; set; }

    public string? MapDescription1LangRuRu { get; set; }

    public string? MapDescription1LangPtPt { get; set; }

    public string? MapDescription1LangPtBr { get; set; }

    public string? MapDescription1LangItIt { get; set; }

    public string? MapDescription1LangUnk { get; set; }

    public uint MapDescription1LangMask { get; set; }

    public int? LoadingScreenId { get; set; }

    public float MinimapIconScale { get; set; }

    public int? CorpseMapId { get; set; }

    public float CorpseX { get; set; }

    public float CorpseY { get; set; }

    public int TimeOfDayOverride { get; set; }

    public int ExpansionId { get; set; }

    public int RaidOffset { get; set; }

    public int MaxPlayers { get; set; }

    public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

    public virtual Areatable? AreaTable { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();

    public virtual ICollection<Areatrigger> Areatriggers { get; set; } = new List<Areatrigger>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId1Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId2Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId3Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId4Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId5Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId6Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId7Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual ICollection<Battlemasterlist> BattlemasterlistMapId8Navigations { get; set; } = new List<Battlemasterlist>();

    public virtual Map? CorpseMap { get; set; }

    public virtual ICollection<Dungeonencounter> Dungeonencounters { get; set; } = new List<Dungeonencounter>();

    public virtual ICollection<Dungeonmapchunk> Dungeonmapchunks { get; set; } = new List<Dungeonmapchunk>();

    public virtual ICollection<Dungeonmap> Dungeonmaps { get; set; } = new List<Dungeonmap>();

    public virtual ICollection<Map> InverseCorpseMap { get; set; } = new List<Map>();

    public virtual ICollection<Lfgdungeon> Lfgdungeons { get; set; } = new List<Lfgdungeon>();

    public virtual Loadingscreen? LoadingScreen { get; set; }

    public virtual ICollection<Mapdifficulty> Mapdifficulties { get; set; } = new List<Mapdifficulty>();

    public virtual ICollection<Pvpdifficulty> Pvpdifficulties { get; set; } = new List<Pvpdifficulty>();

    public virtual ICollection<Soundemitter> Soundemitters { get; set; } = new List<Soundemitter>();

    public virtual ICollection<Taxinode> Taxinodes { get; set; } = new List<Taxinode>();

    public virtual ICollection<Taxipathnode> Taxipathnodes { get; set; } = new List<Taxipathnode>();

    public virtual ICollection<Worldmaparea> WorldmapareaDisplayMaps { get; set; } = new List<Worldmaparea>();

    public virtual ICollection<Worldmaparea> WorldmapareaMaps { get; set; } = new List<Worldmaparea>();

    public virtual ICollection<Worldmapcontinent> Worldmapcontinents { get; set; } = new List<Worldmapcontinent>();

    public virtual ICollection<Worldmaptransform> WorldmaptransformMaps { get; set; } = new List<Worldmaptransform>();

    public virtual ICollection<Worldmaptransform> WorldmaptransformNewMaps { get; set; } = new List<Worldmaptransform>();

    public virtual ICollection<Worldsafeloc> Worldsafelocs { get; set; } = new List<Worldsafeloc>();

    public virtual ICollection<Worldstateui> Worldstateuis { get; set; } = new List<Worldstateui>();
}
