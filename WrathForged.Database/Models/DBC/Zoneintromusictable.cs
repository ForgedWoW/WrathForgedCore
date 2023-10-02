// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ZoneIntroMusicTable.dbc")]
public partial class Zoneintromusictable
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Priority { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int MinDelayMinutes { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();

    public virtual Soundentry? Sound { get; set; }

    public virtual ICollection<Wmoareatable> Wmoareatables { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
}
