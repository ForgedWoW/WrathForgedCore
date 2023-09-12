using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Emotestextdatum
{
    public int Id { get; set; }

    public string? TextLangEnUs { get; set; }

    public string? TextLangEnGb { get; set; }

    public string? TextLangKoKr { get; set; }

    public string? TextLangFrFr { get; set; }

    public string? TextLangDeDe { get; set; }

    public string? TextLangEnCn { get; set; }

    public string? TextLangZhCn { get; set; }

    public string? TextLangEnTw { get; set; }

    public string? TextLangZhTw { get; set; }

    public string? TextLangEsEs { get; set; }

    public string? TextLangEsMx { get; set; }

    public string? TextLangRuRu { get; set; }

    public string? TextLangPtPt { get; set; }

    public string? TextLangPtBr { get; set; }

    public string? TextLangItIt { get; set; }

    public string? TextLangUnk { get; set; }

    public uint TextLangMask { get; set; }

    public virtual ICollection<Emotestext> EmotestextEmoteText10Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText11Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText12Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText13Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText14Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText15Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText16Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText1Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText2Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText3Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText4Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText5Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText6Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText7Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText8Navigations { get; set; } = new List<Emotestext>();

    public virtual ICollection<Emotestext> EmotestextEmoteText9Navigations { get; set; } = new List<Emotestext>();
}
