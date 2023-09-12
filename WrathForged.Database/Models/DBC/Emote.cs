using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Emote
{
    public int Id { get; set; }

    public string? EmoteSlashCommand { get; set; }

    public int? AnimId { get; set; }

    public int EmoteFlags { get; set; }

    public int EmoteSpecProc { get; set; }

    public int EmoteSpecProcParam { get; set; }

    public int? EventSoundId { get; set; }

    public virtual Animationdatum? Anim { get; set; }

    public virtual ICollection<Emotestext> Emotestexts { get; set; } = new List<Emotestext>();

    public virtual Soundentry? EventSound { get; set; }
}
