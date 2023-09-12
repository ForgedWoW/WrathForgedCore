using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Particlecolor
{
    public int Id { get; set; }

    public int Start1 { get; set; }

    public int Start2 { get; set; }

    public int Start3 { get; set; }

    public int Mid1 { get; set; }

    public int Mid2 { get; set; }

    public int Mid3 { get; set; }

    public int End1 { get; set; }

    public int End2 { get; set; }

    public int End3 { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
}
