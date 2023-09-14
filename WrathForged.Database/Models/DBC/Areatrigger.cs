// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AreaTrigger.dbc")]
public partial class Areatrigger
{
    [DBCPropertyBinding(0, DBCBindingType.UINT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.UINT, CanBeNull = true)]
    public int? ContinentId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float X { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Y { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Z { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float Radius { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float BoxLength { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float BoxWidth { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float BoxHeight { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float BoxYaw { get; set; }

    public virtual Map? Continent { get; set; }
}