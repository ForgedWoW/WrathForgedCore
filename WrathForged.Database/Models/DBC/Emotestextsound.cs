using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Emotestextsound
{
    public int Id { get; set; }

    public int? EmotesTextId { get; set; }

    public int? RaceId { get; set; }

    public int SexId { get; set; }

    public int? SoundId { get; set; }

    public virtual Emotestext? EmotesText { get; set; }

    public virtual Chrrace? Race { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
