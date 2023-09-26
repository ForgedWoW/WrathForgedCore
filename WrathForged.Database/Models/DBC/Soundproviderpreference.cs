// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SoundProviderPreferences.dbc")]
    public partial class Soundproviderpreference : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? Description { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int EaxenvironmentSelection { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float EaxdecayTime { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float Eax2environmentSize { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float Eax2environmentDiffusion { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int Eax2room { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int Eax2roomHf { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
        public float Eax2decayHfratio { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int Eax2reflections { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
        public float Eax2reflectionsDelay { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int Eax2reverb { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
        public float Eax2reverbDelay { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
        public float Eax2roomRolloff { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
        public float Eax2airAbsorption { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int Eax3roomLf { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
        public float Eax3decayLfratio { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.FLOAT)]
        public float Eax3echoTime { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
        public float Eax3echoDepth { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
        public float Eax3modulationTime { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
        public float Eax3modulationDepth { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
        public float Eax3hfreference { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
        public float Eax3lfreference { get; set; }

        public virtual ICollection<Areatable> AreatableSoundProviderPrefNavigations { get; set; } = new List<Areatable>();

        public virtual ICollection<Areatable> AreatableSoundProviderPrefUnderwaterNavigations { get; set; } = new List<Areatable>();

        public virtual ICollection<Wmoareatable> WmoareatableSoundProviderPrefNavigations { get; set; } = new List<Wmoareatable>();

        public virtual ICollection<Wmoareatable> WmoareatableSoundProviderPrefUnderwaterNavigations { get; set; } = new List<Wmoareatable>();

        public virtual ICollection<Worldstatezonesound> Worldstatezonesounds { get; set; } = new List<Worldstatezonesound>();
    }
}