using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Languageword
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public string? Word { get; set; }

    public virtual Language? Language { get; set; }
}
