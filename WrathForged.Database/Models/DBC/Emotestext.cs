using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Emotestext
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? EmoteId { get; set; }

    public int? EmoteText1 { get; set; }

    public int? EmoteText2 { get; set; }

    public int? EmoteText3 { get; set; }

    public int? EmoteText4 { get; set; }

    public int? EmoteText5 { get; set; }

    public int? EmoteText6 { get; set; }

    public int? EmoteText7 { get; set; }

    public int? EmoteText8 { get; set; }

    public int? EmoteText9 { get; set; }

    public int? EmoteText10 { get; set; }

    public int? EmoteText11 { get; set; }

    public int? EmoteText12 { get; set; }

    public int? EmoteText13 { get; set; }

    public int? EmoteText14 { get; set; }

    public int? EmoteText15 { get; set; }

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
