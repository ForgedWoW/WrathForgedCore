// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CinematicSequences.dbc")]
public partial class Cinematicsequence : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? Camera1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? Camera2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? Camera3 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? Camera4 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? Camera5 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? Camera6 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? Camera7 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? Camera8 { get; set; }

    public virtual Cinematiccamera? Camera1Navigation { get; set; }

    public virtual Cinematiccamera? Camera2Navigation { get; set; }

    public virtual Cinematiccamera? Camera3Navigation { get; set; }

    public virtual Cinematiccamera? Camera4Navigation { get; set; }

    public virtual Cinematiccamera? Camera5Navigation { get; set; }

    public virtual Cinematiccamera? Camera6Navigation { get; set; }

    public virtual Cinematiccamera? Camera7Navigation { get; set; }

    public virtual Cinematiccamera? Camera8Navigation { get; set; }

    public virtual ICollection<Chrclass> Chrclasses { get; set; } = new List<Chrclass>();

    public virtual ICollection<Chrrace> Chrraces { get; set; } = new List<Chrrace>();

    public virtual Soundentry? Sound { get; set; }
}