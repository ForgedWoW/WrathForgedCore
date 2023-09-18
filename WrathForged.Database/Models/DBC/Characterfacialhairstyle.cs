// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharacterFacialHairStyles.dbc")]
public partial class Characterfacialhairstyle
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int RaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int SexId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int VariationId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Geoset1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Geoset2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Geoset3 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Geoset4 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Geoset5 { get; set; }
}