using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Deaththudlookup
{
    public int Id { get; set; }

    public int SizeClass { get; set; }

    public int? TerraintypeSoundId { get; set; }

    public int? SoundEntryId { get; set; }

    public int? SoundEntryIdwater { get; set; }

    public virtual Soundentry? SoundEntry { get; set; }

    public virtual Soundentry? SoundEntryIdwaterNavigation { get; set; }

    public virtual Terraintype? TerraintypeSound { get; set; }
}
