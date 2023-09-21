// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CreatureModelData.dbc")]
public partial class Creaturemodeldatum : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? ModelName { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int SizeClass { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float ModelScale { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? BloodId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? FootprintTextureId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT, Nullable = true)]
    public float? FootprintTextureLength { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT, Nullable = true)]
    public float? FootprintTextureWidth { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT, Nullable = true)]
    public float? FootprintParticleScale { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int FoleyMaterialId { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? FootstepShakeSize { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? DeathThudShakeSize { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
    public int? SoundId { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float CollisionWidth { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float CollisionHeight { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
    public float MountHeight { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
    public float GeoBoxMinX { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.FLOAT)]
    public float GeoBoxMinY { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float GeoBoxMinZ { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float GeoBoxMaxX { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
    public float GeoBoxMaxY { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
    public float GeoBoxMaxZ { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
    public float WorldEffectScale { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
    public float AttachedEffectScale { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
    public float MissileCollisionRadius { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
    public float MissileCollisionPush { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
    public float MissileCollisionRaise { get; set; }

    public virtual Unitbloodlevel? Blood { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual Camerashake? DeathThudShakeSizeNavigation { get; set; }

    public virtual Footprinttexture? FootprintTexture { get; set; }

    public virtual Camerashake? FootstepShakeSizeNavigation { get; set; }

    public virtual Creaturesounddatum? Sound { get; set; }
}