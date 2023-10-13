// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SoundEntriesAdvanced.dbc")]
public partial class Soundentriesadvanced : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? SoundEntryId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float InnerRadius2D { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int TimeA { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int TimeB { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int TimeC { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int TimeD { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int RandomOffsetRange { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Usage { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int TimeintervalMin { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int TimeintervalMax { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int VolumeSliderCategory { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float DuckToSfx { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
    public float DuckToMusic { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float DuckToAmbience { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float InnerRadiusOfInfluence { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
    public float OuterRadiusOfInfluence { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int TimeToDuck { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int TimeToUnduck { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
    public float InsideAngle { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
    public float OutsideAngle { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
    public float OutsideVolume { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
    public float OuterRadius2D { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? Name { get; set; }

    public virtual Soundentry? SoundEntry { get; set; }

    public virtual ICollection<Soundentry> Soundentries { get; set; } = new List<Soundentry>();
}
