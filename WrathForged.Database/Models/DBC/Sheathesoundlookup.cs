using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Sheathesoundlookup
{
    public int Id { get; set; }

    public int? ItemClass { get; set; }

    public int? ItemSubclass { get; set; }

    public int ItemEnvTypes { get; set; }

    public int IsShield { get; set; }

    public int? SheathSoundId { get; set; }

    public int? UnsheathSoundId { get; set; }

    public virtual Itemsubclass? ItemClassNavigation { get; set; }

    public virtual Itemsubclass? ItemSubclassNavigation { get; set; }

    public virtual Soundentry? SheathSound { get; set; }

    public virtual Soundentry? UnsheathSound { get; set; }
}
