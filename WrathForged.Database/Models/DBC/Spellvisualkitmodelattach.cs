// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spellvisualkitmodelattach
{
    public int Id { get; set; }

    public int? ParentSpellVisualKitId { get; set; }

    public int? SpellVisualEffectNameId { get; set; }

    public int AttachmentId { get; set; }

    public float OffsetX { get; set; }

    public float OffsetY { get; set; }

    public float OffsetZ { get; set; }

    public float Yaw { get; set; }

    public float Pitch { get; set; }

    public float Roll { get; set; }

    public virtual Spellvisualkit? ParentSpellVisualKit { get; set; }

    public virtual Spellvisualeffectname? SpellVisualEffectName { get; set; }
}
