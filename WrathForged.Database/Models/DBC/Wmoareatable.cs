using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Wmoareatable
{
    public int Id { get; set; }

    public int Wmoid { get; set; }

    public int NameSetId { get; set; }

    public int WmogroupId { get; set; }

    public int? SoundProviderPref { get; set; }

    public int? SoundProviderPrefUnderwater { get; set; }

    public int? AmbienceId { get; set; }

    public int? ZoneMusic { get; set; }

    public int? IntroSound { get; set; }

    public int Flags { get; set; }

    public int? AreaTableId { get; set; }

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

    public virtual Soundambience? Ambience { get; set; }

    public virtual Areatable? AreaTable { get; set; }

    public virtual Zoneintromusictable? IntroSoundNavigation { get; set; }

    public virtual Soundproviderpreference? SoundProviderPrefNavigation { get; set; }

    public virtual Soundproviderpreference? SoundProviderPrefUnderwaterNavigation { get; set; }

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();

    public virtual Zonemusic? ZoneMusicNavigation { get; set; }
}
