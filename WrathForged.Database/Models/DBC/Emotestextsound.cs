// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("EmotesTextSound.dbc")]
public partial class Emotestextsound : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? EmotesTextId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? RaceId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int SexId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    public virtual Emotestext? EmotesText { get; set; }
    public virtual Chrrace? Race { get; set; }
    public virtual Soundentry? Sound { get; set; }
}
