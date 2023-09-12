using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundproviderpreference
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int Flags { get; set; }

    public int EaxenvironmentSelection { get; set; }

    public float EaxdecayTime { get; set; }

    public float Eax2environmentSize { get; set; }

    public float Eax2environmentDiffusion { get; set; }

    public int Eax2room { get; set; }

    public int Eax2roomHf { get; set; }

    public float Eax2decayHfratio { get; set; }

    public int Eax2reflections { get; set; }

    public float Eax2reflectionsDelay { get; set; }

    public int Eax2reverb { get; set; }

    public float Eax2reverbDelay { get; set; }

    public float Eax2roomRolloff { get; set; }

    public float Eax2airAbsorption { get; set; }

    public int Eax3roomLf { get; set; }

    public float Eax3decayLfratio { get; set; }

    public float Eax3echoTime { get; set; }

    public float Eax3echoDepth { get; set; }

    public float Eax3modulationTime { get; set; }

    public float Eax3modulationDepth { get; set; }

    public float Eax3hfreference { get; set; }

    public float Eax3lfreference { get; set; }

    public virtual ICollection<Areatable> AreatableSoundProviderPrefNavigations { get; set; } = new List<Areatable>();

    public virtual ICollection<Areatable> AreatableSoundProviderPrefUnderwaterNavigations { get; set; } = new List<Areatable>();

    public virtual ICollection<Wmoareatable> WmoareatableSoundProviderPrefNavigations { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Wmoareatable> WmoareatableSoundProviderPrefUnderwaterNavigations { get; set; } = new List<Wmoareatable>();

    public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
}
