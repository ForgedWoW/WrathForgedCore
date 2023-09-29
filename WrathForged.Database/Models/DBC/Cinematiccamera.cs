// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CinematicCamera.dbc")]
public partial class Cinematiccamera : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Model { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float OriginX { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float OriginY { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float OriginZ { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float OriginFacing { get; set; }

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera1Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera2Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera3Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera4Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera5Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera6Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera7Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual ICollection<Cinematicsequence> CinematicsequenceCamera8Navigations { get; set; } = new List<Cinematicsequence>();

    public virtual Soundentry? Sound { get; set; }
}