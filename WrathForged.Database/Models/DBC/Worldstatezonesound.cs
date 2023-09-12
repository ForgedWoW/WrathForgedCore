using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Worldstatezonesound
{
    public int Id { get; set; }

    public int WorldStateId { get; set; }

    public int WorldStateValue { get; set; }

    public int? AreaId { get; set; }

    public int? WmoareaId { get; set; }

    public int? ZoneintroMusicId { get; set; }

    public int? ZoneMusicId { get; set; }

    public int? SoundAmbienceId { get; set; }

    public int? SoundProviderPreferencesId { get; set; }

    public virtual Areatable? Area { get; set; }

    public virtual Soundambience? SoundAmbience { get; set; }

    public virtual Soundproviderpreference? SoundProviderPreferences { get; set; }

    public virtual Wmoareatable? Wmoarea { get; set; }

    public virtual Zonemusic? ZoneMusic { get; set; }

    public virtual Zoneintromusictable? ZoneintroMusic { get; set; }
}
