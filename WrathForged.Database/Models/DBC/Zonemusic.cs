// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.DBC;

public partial class Zonemusic
{
    public int Id { get; set; }

    public string? SetName { get; set; }

    public int SilenceintervalMin1 { get; set; }

    public int SilenceintervalMin2 { get; set; }

    public int SilenceintervalMax1 { get; set; }

    public int SilenceintervalMax2 { get; set; }

    public int? Sounds1 { get; set; }

    public int? Sounds2 { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();

    public virtual Soundentry? Sounds1Navigation { get; set; }

    public virtual Soundentry? Sounds2Navigation { get; set; }

    public virtual ICollection<Wmoareatable> Wmoareatables { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
}