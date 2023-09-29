// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Terraintype
{
    public int Id { get; set; }

    public int TerrainId { get; set; }

    public string? TerrainDesc { get; set; }

    public int? FootstepSprayRun { get; set; }

    public int? FootstepSprayWalk { get; set; }

    public int? SoundId { get; set; }

    public int Flags { get; set; }

    public virtual ICollection<Deaththudlookup> Deaththudlookups { get; set; } = new List<Deaththudlookup>();

    public virtual Spellvisualeffectname? FootstepSprayRunNavigation { get; set; }

    public virtual Spellvisualeffectname? FootstepSprayWalkNavigation { get; set; }

    public virtual ICollection<Footstepterrainlookup> Footstepterrainlookups { get; set; } = new List<Footstepterrainlookup>();

    public virtual Terraintypesound? Sound { get; set; }
}
