// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ChrRaces.dbc")]
public partial class Chrrace : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? FactionId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? ExplorationSoundId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? MaleDisplayId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? FemaleDisplayId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? ClientPrefix { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int BaseLanguage { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureType { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int ResSicknessSpellId { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int SplashSoundId { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? ClientFilestring { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? CinematicSequenceId { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Alliance { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? NameFemaleLangEnUs { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? NameFemaleLangEnGb { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? NameFemaleLangKoKr { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? NameFemaleLangFrFr { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? NameFemaleLangDeDe { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? NameFemaleLangEnCn { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING)]
    public string? NameFemaleLangZhCn { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? NameFemaleLangEnTw { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.STRING)]
    public string? NameFemaleLangZhTw { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? NameFemaleLangEsEs { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? NameFemaleLangEsMx { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? NameFemaleLangRuRu { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? NameFemaleLangPtPt { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? NameFemaleLangPtBr { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? NameFemaleLangItIt { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? NameFemaleLangUnk { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.UINT32)]
    public uint NameFemaleLangMask { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? NameMaleLangEnUs { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? NameMaleLangEnGb { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? NameMaleLangKoKr { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING)]
    public string? NameMaleLangFrFr { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING)]
    public string? NameMaleLangDeDe { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING)]
    public string? NameMaleLangEnCn { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.STRING)]
    public string? NameMaleLangZhCn { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.STRING)]
    public string? NameMaleLangEnTw { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.STRING)]
    public string? NameMaleLangZhTw { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.STRING)]
    public string? NameMaleLangEsEs { get; set; }

    [DBCPropertyBinding(58, DBCBindingType.STRING)]
    public string? NameMaleLangEsMx { get; set; }

    [DBCPropertyBinding(59, DBCBindingType.STRING)]
    public string? NameMaleLangRuRu { get; set; }

    [DBCPropertyBinding(60, DBCBindingType.STRING)]
    public string? NameMaleLangPtPt { get; set; }

    [DBCPropertyBinding(61, DBCBindingType.STRING)]
    public string? NameMaleLangPtBr { get; set; }

    [DBCPropertyBinding(62, DBCBindingType.STRING)]
    public string? NameMaleLangItIt { get; set; }

    [DBCPropertyBinding(63, DBCBindingType.STRING)]
    public string? NameMaleLangUnk { get; set; }

    [DBCPropertyBinding(64, DBCBindingType.UINT32)]
    public uint NameMaleLangMask { get; set; }

    [DBCPropertyBinding(65, DBCBindingType.STRING)]
    public string? FacialHairCustomization1 { get; set; }

    [DBCPropertyBinding(66, DBCBindingType.STRING)]
    public string? FacialHairCustomization2 { get; set; }

    [DBCPropertyBinding(67, DBCBindingType.STRING)]
    public string? HairCustomization { get; set; }

    [DBCPropertyBinding(68, DBCBindingType.INT32)]
    public int RequiredExpansion { get; set; }

    public virtual ICollection<Charbaseinfo> Charbaseinfos { get; set; } = new List<Charbaseinfo>();

    public virtual ICollection<Charhairgeoset> Charhairgeosets { get; set; } = new List<Charhairgeoset>();

    public virtual ICollection<Charhairtexture> Charhairtextures { get; set; } = new List<Charhairtexture>();

    public virtual ICollection<Charsection> Charsections { get; set; } = new List<Charsection>();

    public virtual ICollection<Charstartoutfit> Charstartoutfits { get; set; } = new List<Charstartoutfit>();

    public virtual Cinematicsequence? CinematicSequence { get; set; }

    public virtual Creaturetype? CreatureTypeNavigation { get; set; }

    public virtual ICollection<Creaturedisplayinfoextra> Creaturedisplayinfoextras { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Emotestextsound> Emotestextsounds { get; set; } = new List<Emotestextsound>();

    public virtual Soundentry? ExplorationSound { get; set; }

    public virtual Factiontemplate? Faction { get; set; }

    public virtual Creaturedisplayinfo? FemaleDisplay { get; set; }

    public virtual Creaturedisplayinfo? MaleDisplay { get; set; }

    public virtual ICollection<Namegen> Namegens { get; set; } = new List<Namegen>();

    public virtual ICollection<Vocaluisound> Vocaluisounds { get; set; } = new List<Vocaluisound>();
}