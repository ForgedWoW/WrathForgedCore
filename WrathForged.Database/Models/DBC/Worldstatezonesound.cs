// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WorldStateZoneSounds.dbc")]
public partial class Worldstatezonesound
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int WorldStateId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int WorldStateValue { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? AreaId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? WmoareaId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? ZoneintroMusicId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? ZoneMusicId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? SoundAmbienceId { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? SoundProviderPreferencesId { get; set; }

    public virtual Areatable? Area { get; set; }

    public virtual Soundambience? SoundAmbience { get; set; }

    public virtual Soundproviderpreference? SoundProviderPreferences { get; set; }

    public virtual Wmoareatable? Wmoarea { get; set; }

    public virtual Zonemusic? ZoneMusic { get; set; }

    public virtual Zoneintromusictable? ZoneintroMusic { get; set; }
}
