using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Unitbloodlevel
{
    public int Id { get; set; }

    public int Violencelevel1 { get; set; }

    public int Violencelevel2 { get; set; }

    public int Violencelevel3 { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual ICollection<Creaturemodeldatum> Creaturemodeldata { get; set; } = new List<Creaturemodeldatum>();
}
