using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundambience
{
    public int Id { get; set; }

    public int? AmbienceId1 { get; set; }

    public int? AmbienceId2 { get; set; }

    public virtual Soundentry? AmbienceId1Navigation { get; set; }

    public virtual Soundentry? AmbienceId2Navigation { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();

    public virtual ICollection<Wmoareatable> Wmoareatables { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
}
