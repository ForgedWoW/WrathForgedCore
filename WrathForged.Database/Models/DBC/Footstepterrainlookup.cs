using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Footstepterrainlookup
{
    public int Id { get; set; }

    public int? CreatureFootstepId { get; set; }

    public int? TerrainSoundId { get; set; }

    public int? SoundId { get; set; }

    public int? SoundIdsplash { get; set; }

    public virtual Groundeffectdoodad? CreatureFootstep { get; set; }

    public virtual Soundentry? Sound { get; set; }

    public virtual Soundentry? SoundIdsplashNavigation { get; set; }

    public virtual Terraintype? TerrainSound { get; set; }
}
