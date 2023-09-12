using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Animationdatum
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Weaponflags { get; set; }

    public int Bodyflags { get; set; }

    public int Flags { get; set; }

    public int Fallback { get; set; }

    public int BehaviorId { get; set; }

    public int BehaviorTier { get; set; }

    public virtual ICollection<Attackanimkit> Attackanimkits { get; set; } = new List<Attackanimkit>();

    public virtual ICollection<Emote> Emotes { get; set; } = new List<Emote>();

    public virtual ICollection<Spellvisualkit> SpellvisualkitAnims { get; set; } = new List<Spellvisualkit>();

    public virtual ICollection<Spellvisualkit> SpellvisualkitStartAnims { get; set; } = new List<Spellvisualkit>();

    public virtual ICollection<Transportanimation> Transportanimations { get; set; } = new List<Transportanimation>();
}
