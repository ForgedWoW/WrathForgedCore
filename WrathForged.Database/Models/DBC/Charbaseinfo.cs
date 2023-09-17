// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharBaseInfo.dbc")]
public partial class Charbaseinfo
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT, Nullable = true)]
    public int? RaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT, Nullable = true)]
    public int? ClassId { get; set; }

    public virtual Chrclass? Class { get; set; }

    public virtual Chrrace? Race { get; set; }
}