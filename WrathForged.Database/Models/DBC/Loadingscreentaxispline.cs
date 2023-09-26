// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("LoadingScreenTaxiSplines.dbc")]
public partial class Loadingscreentaxispline : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? PathId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float Locx1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Locx2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Locx3 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float Locx4 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float Locx5 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float Locx6 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float Locx7 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float Locx8 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float Locy1 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
    public float Locy2 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float Locy3 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
    public float Locy4 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float Locy5 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float Locy6 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.FLOAT)]
    public float Locy7 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.FLOAT)]
    public float Locy8 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int LegIndex { get; set; }

    public virtual Taxipath? Path { get; set; }
}
