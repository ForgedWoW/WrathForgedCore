using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Vocaluisound
{
    public int Id { get; set; }

    public int VocalUienum { get; set; }

    public int? RaceId { get; set; }

    public int? NormalSoundId1 { get; set; }

    public int? NormalSoundId2 { get; set; }

    public int? PissedSoundId1 { get; set; }

    public int? PissedSoundId2 { get; set; }

    public virtual Soundentry? NormalSoundId1Navigation { get; set; }

    public virtual Soundentry? NormalSoundId2Navigation { get; set; }

    public virtual Soundentry? PissedSoundId1Navigation { get; set; }

    public virtual Soundentry? PissedSoundId2Navigation { get; set; }

    public virtual Chrrace? Race { get; set; }
}
