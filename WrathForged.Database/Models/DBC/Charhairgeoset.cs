// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharHairGeosets.dbc")]
public partial class Charhairgeoset
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT, Nullable = true)]
    public int? RaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT)]
    public int SexId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT)]
    public int VariationId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT)]
    public int GeosetId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT)]
    public int Showscalp { get; set; }

    public virtual Chrrace? Race { get; set; }
}