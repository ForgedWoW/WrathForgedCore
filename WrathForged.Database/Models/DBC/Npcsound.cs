using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Npcsound
{
    public int Id { get; set; }

    public int? SoundId1 { get; set; }

    public int? SoundId2 { get; set; }

    public int? SoundId3 { get; set; }

    public int? SoundId4 { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual Soundentry? SoundId1Navigation { get; set; }

    public virtual Soundentry? SoundId2Navigation { get; set; }

    public virtual Soundentry? SoundId3Navigation { get; set; }

    public virtual Soundentry? SoundId4Navigation { get; set; }
}
