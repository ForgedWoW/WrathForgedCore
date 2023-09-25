// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("GroundEffectDoodad.dbc")]
    public partial class Groundeffectdoodad : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? Doodadpath { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Flags { get; set; }

        public virtual ICollection<Footstepterrainlookup> Footstepterrainlookups { get; set; } = new List<Footstepterrainlookup>();
        public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId1Navigations { get; set; } = new List<Groundeffecttexture>();
        public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId2Navigations { get; set; } = new List<Groundeffecttexture>();
        public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId3Navigations { get; set; } = new List<Groundeffecttexture>();
        public virtual ICollection<Groundeffecttexture> GroundeffecttextureDoodadId4Navigations { get; set; } = new List<Groundeffecttexture>();
    }
}
