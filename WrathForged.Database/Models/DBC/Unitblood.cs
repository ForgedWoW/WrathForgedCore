using System;
using System.Collections.Generic;

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
