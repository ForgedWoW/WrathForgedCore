// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
