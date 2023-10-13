// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("FootstepTerrainLookup.dbc")]
public partial class Footstepterrainlookup : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? CreatureFootstepId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? TerrainSoundId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? SoundIdsplash { get; set; }

    public virtual Groundeffectdoodad? CreatureFootstep { get; set; }
    public virtual Soundentry? Sound { get; set; }
    public virtual Soundentry? SoundIdsplashNavigation { get; set; }
    public virtual Terraintype? TerrainSound { get; set; }
}
