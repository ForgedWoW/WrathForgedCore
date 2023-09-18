using System;
using System.Collections.Generic;
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ChrClasses.dbc")]
public partial class Chrclass
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Field01 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int DisplayPower { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int PetNameToken { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? NameFemaleLangEnUs { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? NameFemaleLangEnGb { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? NameFemaleLangKoKr { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? NameFemaleLangFrFr { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? NameFemaleLangDeDe { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? NameFemaleLangEnCn { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? NameFemaleLangZhCn { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? NameFemaleLangEnTw { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? NameFemaleLangZhTw { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? NameFemaleLangEsEs { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? NameFemaleLangEsMx { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? NameFemaleLangRuRu { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? NameFemaleLangPtPt { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? NameFemaleLangPtBr { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? NameFemaleLangItIt { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? NameFemaleLangUnk { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.UINT32)]
    public uint NameFemaleLangMask { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? NameMaleLangEnUs { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.STRING)]
    public string? NameMaleLangEnGb { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? NameMaleLangKoKr { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? NameMaleLangFrFr { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? NameMaleLangDeDe { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? NameMaleLangEnCn { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? NameMaleLangZhCn { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? NameMaleLangEnTw { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? NameMaleLangZhTw { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING)]
    public string? NameMaleLangEsEs { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? NameMaleLangEsMx { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? NameMaleLangRuRu { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? NameMaleLangPtPt { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING)]
    public string? NameMaleLangPtBr { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING)]
    public string? NameMaleLangItIt { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING)]
    public string? NameMaleLangUnk { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.UINT32)]
    public uint NameMaleLangMask { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.STRING)]
    public string? Filename { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.INT32)]
    public int SpellClassSet { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(58, DBCBindingType.INT32, Nullable = true)]
    public int? CinematicSequenceId { get; set; }

    [DBCPropertyBinding(59, DBCBindingType.INT32)]
    public int RequiredExpansion { get; set; }

    public virtual ICollection<Charbaseinfo> Charbaseinfos { get; set; } = new List<Charbaseinfo>();

    public virtual ICollection<Charstartoutfit> Charstartoutfits { get; set; } = new List<Charstartoutfit>();

    public virtual Cinematicsequence? CinematicSequence { get; set; }
}
