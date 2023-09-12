using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemgroupsound
{
    public int Id { get; set; }

    public int? Sound1 { get; set; }

    public int? Sound2 { get; set; }

    public int? Sound3 { get; set; }

    public int? Sound4 { get; set; }

    public virtual ICollection<Itemdisplayinfo> Itemdisplayinfos { get; set; } = new List<Itemdisplayinfo>();

    public virtual Soundentry? Sound1Navigation { get; set; }

    public virtual Soundentry? Sound2Navigation { get; set; }

    public virtual Soundentry? Sound3Navigation { get; set; }

    public virtual Soundentry? Sound4Navigation { get; set; }
}
