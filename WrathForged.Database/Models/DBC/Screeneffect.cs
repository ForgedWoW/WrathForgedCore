// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ScreenEffect.dbc")]
public partial class Screeneffect : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? Name { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Effect { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Param1 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Param2 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Param3 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Param4 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int LightParamsId { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int SoundAmbienceId { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int ZoneMusicId { get; set; }
}
