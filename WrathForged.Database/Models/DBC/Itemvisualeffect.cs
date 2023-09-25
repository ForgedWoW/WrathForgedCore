// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ItemVisualEffects.dbc")]
    public partial class Itemvisualeffect : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? Model { get; set; }

        public virtual ICollection<Itemvisual> ItemvisualSlot1Navigations { get; set; } = new List<Itemvisual>();
        public virtual ICollection<Itemvisual> ItemvisualSlot2Navigations { get; set; } = new List<Itemvisual>();
        public virtual ICollection<Itemvisual> ItemvisualSlot3Navigations { get; set; } = new List<Itemvisual>();
        public virtual ICollection<Itemvisual> ItemvisualSlot4Navigations { get; set; } = new List<Itemvisual>();
        public virtual ICollection<Itemvisual> ItemvisualSlot5Navigations { get; set; } = new List<Itemvisual>();
    }
}
