using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Declinedwordcase
{
    public int Id { get; set; }

    public int? DeclinedWordId { get; set; }

    public int CaseIndex { get; set; }

    public string? DeclinedWord { get; set; }

    public virtual Declinedword? DeclinedWordNavigation { get; set; }
}
