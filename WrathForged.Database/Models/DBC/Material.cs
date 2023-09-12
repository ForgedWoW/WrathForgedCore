using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Material
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public int? FoleySoundId { get; set; }

    public int? SheatheSoundId { get; set; }

    public int? UnsheatheSoundId { get; set; }

    public virtual Soundentry? FoleySound { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Soundentry? SheatheSound { get; set; }

    public virtual Soundentry? UnsheatheSound { get; set; }
}
