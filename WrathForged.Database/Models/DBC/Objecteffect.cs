using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Objecteffect
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ObjectEffectGroupId { get; set; }

    public int TriggerType { get; set; }

    public int EventType { get; set; }

    public int EffectRecType { get; set; }

    public int EffectRecId { get; set; }

    public int Attachment { get; set; }

    public float OffsetX { get; set; }

    public float OffsetY { get; set; }

    public float OffsetZ { get; set; }

    public int? ObjectEffectModifierId { get; set; }

    public virtual Objecteffectgroup? ObjectEffectGroup { get; set; }

    public virtual Objecteffectmodifier? ObjectEffectModifier { get; set; }
}
