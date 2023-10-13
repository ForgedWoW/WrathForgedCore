// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("HelmetGeosetVisData.dbc")]
public partial class Helmetgeosetvisdatum : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int HideGeoset1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int HideGeoset2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int HideGeoset3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int HideGeoset4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int HideGeoset5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int HideGeoset6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int HideGeoset7 { get; set; }

    public virtual ICollection<Itemdisplayinfo> ItemdisplayinfoHelmetGeosetVis1Navigations { get; set; } = new List<Itemdisplayinfo>();
    public virtual ICollection<Itemdisplayinfo> ItemdisplayinfoHelmetGeosetVis2Navigations { get; set; } = new List<Itemdisplayinfo>();
}
