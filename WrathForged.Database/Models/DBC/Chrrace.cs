using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Chrrace
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public int? FactionId { get; set; }

    public int? ExplorationSoundId { get; set; }

    public int? MaleDisplayId { get; set; }

    public int? FemaleDisplayId { get; set; }

    public string? ClientPrefix { get; set; }

    public int BaseLanguage { get; set; }

    public int? CreatureType { get; set; }

    public int ResSicknessSpellId { get; set; }

    public int SplashSoundId { get; set; }

    public string? ClientFilestring { get; set; }

    public int? CinematicSequenceId { get; set; }

    public int Alliance { get; set; }

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

    public string? NameFemaleLangEnUs { get; set; }

    public string? NameFemaleLangEnGb { get; set; }

    public string? NameFemaleLangKoKr { get; set; }

    public string? NameFemaleLangFrFr { get; set; }

    public string? NameFemaleLangDeDe { get; set; }

    public string? NameFemaleLangEnCn { get; set; }

    public string? NameFemaleLangZhCn { get; set; }

    public string? NameFemaleLangEnTw { get; set; }

    public string? NameFemaleLangZhTw { get; set; }

    public string? NameFemaleLangEsEs { get; set; }

    public string? NameFemaleLangEsMx { get; set; }

    public string? NameFemaleLangRuRu { get; set; }

    public string? NameFemaleLangPtPt { get; set; }

    public string? NameFemaleLangPtBr { get; set; }

    public string? NameFemaleLangItIt { get; set; }

    public string? NameFemaleLangUnk { get; set; }

    public uint NameFemaleLangMask { get; set; }

    public string? NameMaleLangEnUs { get; set; }

    public string? NameMaleLangEnGb { get; set; }

    public string? NameMaleLangKoKr { get; set; }

    public string? NameMaleLangFrFr { get; set; }

    public string? NameMaleLangDeDe { get; set; }

    public string? NameMaleLangEnCn { get; set; }

    public string? NameMaleLangZhCn { get; set; }

    public string? NameMaleLangEnTw { get; set; }

    public string? NameMaleLangZhTw { get; set; }

    public string? NameMaleLangEsEs { get; set; }

    public string? NameMaleLangEsMx { get; set; }

    public string? NameMaleLangRuRu { get; set; }

    public string? NameMaleLangPtPt { get; set; }

    public string? NameMaleLangPtBr { get; set; }

    public string? NameMaleLangItIt { get; set; }

    public string? NameMaleLangUnk { get; set; }

    public uint NameMaleLangMask { get; set; }

    public string? FacialHairCustomization1 { get; set; }

    public string? FacialHairCustomization2 { get; set; }

    public string? HairCustomization { get; set; }

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
