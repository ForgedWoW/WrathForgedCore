// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CreatureDisplayInfo.dbc")]
public partial class Creaturedisplayinfo : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? ModelId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? ExtendedDisplayInfoId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float CreatureModelScale { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int CreatureModelAlpha { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? TextureVariation1 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? TextureVariation2 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? TextureVariation3 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? PortraitTextureName { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? BloodLevel { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? BloodId { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? NpcsoundId { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
    public int? ParticleColorId { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int CreatureGeosetData { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
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