// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Weather.dbc")]
public partial class Weather : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? AmbienceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int EffectType { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float TransitionSkyBox { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float EffectColor1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float EffectColor2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float EffectColor3 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? EffectTexture { get; set; }

    public virtual Soundentry? Ambience { get; set; }
}
