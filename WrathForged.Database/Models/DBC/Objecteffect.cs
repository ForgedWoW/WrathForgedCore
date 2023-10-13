// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ObjectEffect.dbc")]
public partial class Objecteffect : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? ObjectEffectGroupId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int TriggerType { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int EventType { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int EffectRecType { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int EffectRecId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Attachment { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float OffsetX { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float OffsetY { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float OffsetZ { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? ObjectEffectModifierId { get; set; }

    public virtual Objecteffectgroup? ObjectEffectGroup { get; set; }
    public virtual Objecteffectmodifier? ObjectEffectModifier { get; set; }
}
