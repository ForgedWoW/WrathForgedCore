// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("LFGDungeons.dbc")]
    public partial class Lfgdungeon : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? NameLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING)]
        public string? NameLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING)]
        public string? NameLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING)]
        public string? NameLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING)]
        public string? NameLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING)]
        public string? NameLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING)]
        public string? NameLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING)]
        public string? NameLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING)]
        public string? NameLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING)]
        public string? NameLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING)]
        public string? NameLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING)]
        public string? NameLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING)]
        public string? NameLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING)]
        public string? NameLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? NameLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? NameLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint NameLangMask { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int MinLevel { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32)]
        public int MaxLevel { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32)]
        public int TargetLevel { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int TargetLevelMin { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
        public int TargetLevelMax { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.INT32)]
        public int? MapId { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.INT32)]
        public int Difficulty { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.INT32)]
        public int TypeId { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.INT32)]
        public int? Faction { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.STRING)]
        public string? TextureFilename { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.INT32)]
        public int ExpansionLevel { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.INT32)]
        public int OrderIndex { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.INT32)]
        public int GroupId { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.STRING)]
        public string? DescriptionLangEnUs { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.STRING)]
        public string? DescriptionLangEnGb { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.STRING)]
        public string? DescriptionLangKoKr { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.STRING)]
        public string? DescriptionLangFrFr { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.STRING)]
        public string? DescriptionLangDeDe { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.STRING)]
        public string? DescriptionLangEnCn { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.STRING)]
        public string? DescriptionLangZhCn { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.STRING)]
        public string? DescriptionLangEnTw { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.STRING)]
        public string? DescriptionLangZhTw { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.STRING)]
        public string? DescriptionLangEsEs { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.STRING)]
        public string? DescriptionLangEsMx { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.STRING)]
        public string? DescriptionLangRuRu { get; set; }

        [DBCPropertyBinding(44, DBCBindingType.STRING)]
        public string? DescriptionLangPtPt { get; set; }

        [DBCPropertyBinding(45, DBCBindingType.STRING)]
        public string? DescriptionLangPtBr { get; set; }

        [DBCPropertyBinding(46, DBCBindingType.STRING)]
        public string? DescriptionLangItIt { get; set; }

        [DBCPropertyBinding(47, DBCBindingType.STRING)]
        public string? DescriptionLangUnk { get; set; }

        [DBCPropertyBinding(48, DBCBindingType.UINT32)]
        public uint DescriptionLangMask { get; set; }

        public virtual Faction? FactionNavigation { get; set; }
        public virtual ICollection<Lfgdungeonexpansion> Lfgdungeonexpansions { get; set; } = new List<Lfgdungeonexpansion>();
        public virtual Map? Map { get; set; }
    }
}
