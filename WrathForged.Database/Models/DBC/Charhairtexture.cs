using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Charhairtexture
{
    public int Id { get; set; }

    public int? Race { get; set; }

    public byte Gender { get; set; }

    public byte Field03 { get; set; }

    public int Field041 { get; set; }

    public int Field042 { get; set; }

    public int Field043 { get; set; }

    public int Field044 { get; set; }

    public virtual Chrrace? RaceNavigation { get; set; }
}
