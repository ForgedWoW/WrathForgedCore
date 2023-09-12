using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellvisualeffectname
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? FileName { get; set; }

    public float AreaEffectSize { get; set; }

    public float Scale { get; set; }

    public float MinAllowedScale { get; set; }

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
