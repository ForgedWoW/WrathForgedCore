using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Objecteffectpackage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual ICollection<Gameobjectdisplayinfo> Gameobjectdisplayinfos { get; set; } = new List<Gameobjectdisplayinfo>();

    public virtual ICollection<Objecteffectpackageelem> Objecteffectpackageelems { get; set; } = new List<Objecteffectpackageelem>();
}
