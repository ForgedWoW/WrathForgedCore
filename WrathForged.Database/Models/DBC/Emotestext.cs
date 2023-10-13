// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("EmotesText.dbc")]
public partial class Emotestext : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText1 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText2 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText3 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText4 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText5 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText6 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText7 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText8 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText9 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText10 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText11 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText12 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText13 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText14 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText15 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
    public int? EmoteText16 { get; set; }

    public virtual Emote? Emote { get; set; }

    public virtual Emotestextdatum? EmoteText10Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText11Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText12Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText13Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText14Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText15Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText16Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText1Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText2Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText3Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText4Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText5Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText6Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText7Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText8Navigation { get; set; }

    public virtual Emotestextdatum? EmoteText9Navigation { get; set; }

    public virtual ICollection<Emotestextsound> Emotestextsounds { get; set; } = new List<Emotestextsound>();
}
