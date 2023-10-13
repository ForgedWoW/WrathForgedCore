// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Declinedwordcase.dbc")]
public partial class Declinedwordcase : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? DeclinedWordId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int CaseIndex { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? DeclinedWord { get; set; }

    public virtual Declinedword? DeclinedWordNavigation { get; set; }
}
