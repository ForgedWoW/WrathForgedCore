using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Creaturedisplayinfo
{
    public int Id { get; set; }

    public int? ModelId { get; set; }

    public int? SoundId { get; set; }

    public int? ExtendedDisplayInfoId { get; set; }

    public float CreatureModelScale { get; set; }

    public int CreatureModelAlpha { get; set; }

    public string? TextureVariation1 { get; set; }

    public string? TextureVariation2 { get; set; }

    public string? TextureVariation3 { get; set; }

    public string? PortraitTextureName { get; set; }

    public int? BloodLevel { get; set; }

    public int? BloodId { get; set; }

    public int? NpcsoundId { get; set; }

    public int? ParticleColorId { get; set; }

    public int CreatureGeosetData { get; set; }

    public int? ObjectEffectPackageId { get; set; }

    public virtual Unitblood? Blood { get; set; }

    public virtual Unitbloodlevel? BloodLevelNavigation { get; set; }

    public virtual ICollection<Chrrace> ChrraceFemaleDisplays { get; set; } = new List<Chrrace>();

    public virtual ICollection<Chrrace> ChrraceMaleDisplays { get; set; } = new List<Chrrace>();

    public virtual Creaturedisplayinfoextra? ExtendedDisplayInfo { get; set; }

    public virtual Creaturemodeldatum? Model { get; set; }

    public virtual Npcsound? Npcsound { get; set; }

    public virtual Objecteffectpackage? ObjectEffectPackage { get; set; }

    public virtual Particlecolor? ParticleColor { get; set; }

    public virtual Creaturesounddatum? Sound { get; set; }

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformCreatureDisplayId1Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformCreatureDisplayId2Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformCreatureDisplayId3Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformCreatureDisplayId4Navigations { get; set; } = new List<Spellshapeshiftform>();
}
