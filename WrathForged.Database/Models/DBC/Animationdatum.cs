// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AnimationData.dbc")]
public partial class Animationdatum
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT)]
    public int Weaponflags { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT)]
    public int Bodyflags { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT)]
    public int Flags { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT)]
    public int Fallback { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT)]
    public int BehaviorId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT)]
    public int BehaviorTier { get; set; }

    public virtual ICollection<Attackanimkit> Attackanimkits { get; set; } = new List<Attackanimkit>();

    public virtual ICollection<Emote> Emotes { get; set; } = new List<Emote>();

    public virtual ICollection<Spellvisualkit> SpellvisualkitAnims { get; set; } = new List<Spellvisualkit>();

    public virtual ICollection<Spellvisualkit> SpellvisualkitStartAnims { get; set; } = new List<Spellvisualkit>();

    public virtual ICollection<Transportanimation> Transportanimations { get; set; } = new List<Transportanimation>();
}