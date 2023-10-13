// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellEffectCameraShakes.dbc")]
public partial class Spelleffectcamerashake : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? CameraShake1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? CameraShake2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? CameraShake3 { get; set; }

    public virtual Camerashake? CameraShake1Navigation { get; set; }
    public virtual Camerashake? CameraShake2Navigation { get; set; }
    public virtual Camerashake? CameraShake3Navigation { get; set; }
    public virtual ICollection<Spellvisualkit> Spellvisualkits { get; set; } = new List<Spellvisualkit>();
}
