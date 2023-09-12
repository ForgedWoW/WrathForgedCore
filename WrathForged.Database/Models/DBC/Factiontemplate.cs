using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Factiontemplate
{
    public int Id { get; set; }

    public int? Faction { get; set; }

    public int Flags { get; set; }

    public int FactionGroup { get; set; }

    public int FriendGroup { get; set; }

    public int EnemyGroup { get; set; }

    public int? Enemies1 { get; set; }

    public int? Enemies2 { get; set; }

    public int? Enemies3 { get; set; }

    public int? Enemies4 { get; set; }

    public int? Friend1 { get; set; }

    public int? Friend2 { get; set; }

    public int? Friend3 { get; set; }

    public int? Friend4 { get; set; }

    public virtual ICollection<Chrrace> Chrraces { get; set; } = new List<Chrrace>();

    public virtual Faction? Enemies1Navigation { get; set; }

    public virtual Faction? Enemies2Navigation { get; set; }

    public virtual Faction? Enemies3Navigation { get; set; }

    public virtual Faction? Enemies4Navigation { get; set; }

    public virtual Faction? FactionNavigation { get; set; }

    public virtual Faction? Friend1Navigation { get; set; }

    public virtual Faction? Friend2Navigation { get; set; }

    public virtual Faction? Friend3Navigation { get; set; }

    public virtual Faction? Friend4Navigation { get; set; }
}
