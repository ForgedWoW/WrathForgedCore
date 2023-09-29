// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Unitblood
{
    public int Id { get; set; }

    public int CombatBloodSpurtFront1 { get; set; }

    public int CombatBloodSpurtFront2 { get; set; }

    public int CombatBloodSpurtBack1 { get; set; }

    public int CombatBloodSpurtBack2 { get; set; }

    public string? GroundBlood1 { get; set; }

    public string? GroundBlood2 { get; set; }

    public string? GroundBlood3 { get; set; }

    public string? GroundBlood4 { get; set; }

    public string? GroundBlood5 { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
}
