using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Chatprofanity
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public int Language { get; set; }
}
