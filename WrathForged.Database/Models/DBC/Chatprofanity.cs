using System;
using System.Collections.Generic;
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ChatProfanity.dbc")]
public partial class Chatprofanity
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Text { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Language { get; set; }
}
