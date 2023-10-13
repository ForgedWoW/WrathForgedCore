// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Map.dbc")]
public partial class Map : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Directory { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int InstanceType { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Pvp { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? MapNameLangEnUs { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? MapNameLangEnGb { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? MapNameLangKoKr { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? MapNameLangFrFr { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? MapNameLangDeDe { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? MapNameLangEnCn { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? MapNameLangZhCn { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? MapNameLangEnTw { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? MapNameLangZhTw { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? MapNameLangEsEs { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? MapNameLangEsMx { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? MapNameLangRuRu { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? MapNameLangPtPt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? MapNameLangPtBr { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? MapNameLangItIt { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? MapNameLangUnk { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.UINT32)]
    public uint MapNameLangMask { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int? AreaTableId { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? MapDescription0LangEnUs { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? MapDescription0LangEnGb { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? MapDescription0LangKoKr { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? MapDescription0LangFrFr { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? MapDescription0LangDeDe { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? MapDescription0LangEnCn { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? MapDescription0LangZhCn { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? MapDescription0LangEnTw { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? MapDescription0LangZhTw { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? MapDescription0LangEsEs { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? MapDescription0LangEsMx { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? MapDescription0LangRuRu { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? MapDescription0LangPtPt { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? MapDescription0LangPtBr { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING)]
    public string? MapDescription0LangItIt { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? MapDescription0LangUnk { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.UINT32)]
    public uint MapDescription0LangMask { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? MapDescription1LangEnUs { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? MapDescription1LangEnGb { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? MapDescription1LangKoKr { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? MapDescription1LangFrFr { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? MapDescription1LangDeDe { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? MapDescription1LangEnCn { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? MapDescription1LangZhCn { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING)]
    public string? MapDescription1LangEnTw { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? MapDescription1LangZhTw { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? MapDescription1LangEsEs { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? MapDescription1LangEsMx { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING)]
    public string? MapDescription1LangRuRu { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING)]
    public string? MapDescription1LangPtPt { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING)]
    public string? MapDescription1LangPtBr { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.STRING)]
    public string? MapDescription1LangItIt { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.STRING)]
    public string? MapDescription1LangUnk { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.UINT32)]
    public uint MapDescription1LangMask { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.INT32)]
    public int? LoadingScreenId { get; set; }

    [DBCPropertyBinding(58, DBCBindingType.FLOAT)]
    public float MinimapIconScale { get; set; }

    [DBCPropertyBinding(59, DBCBindingType.INT32)]
    public int? CorpseMapId { get; set; }

    [DBCPropertyBinding(60, DBCBindingType.FLOAT)]
    public float CorpseX { get; set; }

    [DBCPropertyBinding(61, DBCBindingType.FLOAT)]
    public float CorpseY { get; set; }

    [DBCPropertyBinding(62, DBCBindingType.INT32)]
    public int TimeOfDayOverride { get; set; }

    [DBCPropertyBinding(63, DBCBindingType.INT32)]
    public int ExpansionId { get; set; }

    [DBCPropertyBinding(64, DBCBindingType.INT32)]
    public int RaidOffset { get; set; }

    [DBCPropertyBinding(65, DBCBindingType.INT32)]
    public int MaxPlayers { get; set; }

    // Virtual collections and references are not annotated with DBCPropertyBinding
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
