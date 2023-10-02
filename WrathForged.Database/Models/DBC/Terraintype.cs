// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("TerrainType.dbc")]
    public partial class Terraintype : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int TerrainId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? TerrainDesc { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? FootstepSprayRun { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? FootstepSprayWalk { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int Flags { get; set; }

        public virtual ICollection<Deaththudlookup> Deaththudlookups { get; set; } = new List<Deaththudlookup>();
        public virtual Spellvisualeffectname? FootstepSprayRunNavigation { get; set; }
        public virtual Spellvisualeffectname? FootstepSprayWalkNavigation { get; set; }
        public virtual ICollection<Footstepterrainlookup> Footstepterrainlookups { get; set; } = new List<Footstepterrainlookup>();
        public virtual Terraintypesound? Sound { get; set; }
    }
}
