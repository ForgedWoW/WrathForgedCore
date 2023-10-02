// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellVisualEffectName.dbc")]
    public partial class Spellvisualeffectname : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? Name { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? FileName { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
        public float AreaEffectSize { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float Scale { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float MinAllowedScale { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float MaxAllowedScale { get; set; }

        public virtual ICollection<Spellvisualkit> SpellvisualkitBaseEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitBreathEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitChestEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitHeadEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitLeftHandEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitLeftWeaponEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitRightHandEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitRightWeaponEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitSpecialEffect1Navigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitSpecialEffect2Navigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitSpecialEffect3Navigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkit> SpellvisualkitWorldEffectNavigations { get; set; } = new List<Spellvisualkit>();
        public virtual ICollection<Spellvisualkitmodelattach> Spellvisualkitmodelattaches { get; set; } = new List<Spellvisualkitmodelattach>();
        public virtual ICollection<Spellvisual> Spellvisuals { get; set; } = new List<Spellvisual>();
        public virtual ICollection<Terraintype> TerraintypeFootstepSprayRunNavigations { get; set; } = new List<Terraintype>();
        public virtual ICollection<Terraintype> TerraintypeFootstepSprayWalkNavigations { get; set; } = new List<Terraintype>();
    }
}
