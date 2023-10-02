// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ZoneMusic.dbc")]
public partial class Zonemusic
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? SetName { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int SilenceintervalMin1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int SilenceintervalMin2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int SilenceintervalMax1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int SilenceintervalMax2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? Sounds1 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? Sounds2 { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();

    public virtual Soundentry? Sounds1Navigation { get; set; }

    public virtual Soundentry? Sounds2Navigation { get; set; }

    public virtual ICollection<Wmoareatable> Wmoareatables { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
}