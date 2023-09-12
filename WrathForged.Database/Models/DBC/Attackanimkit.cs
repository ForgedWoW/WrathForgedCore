using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Attackanimkit
{
    public int Id { get; set; }

    public int? Animation { get; set; }

    public int? Type { get; set; }

    public int Flags { get; set; }

    public int Field04 { get; set; }

    public virtual Animationdatum? AnimationNavigation { get; set; }

    public virtual Attackanimtype? TypeNavigation { get; set; }
}
