using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Helmetgeosetvisdatum
{
    public int Id { get; set; }

    public int HideGeoset1 { get; set; }

    public int HideGeoset2 { get; set; }

    public int HideGeoset3 { get; set; }

    public int HideGeoset4 { get; set; }

    public int HideGeoset5 { get; set; }

    public int HideGeoset6 { get; set; }

    public int HideGeoset7 { get; set; }

    public virtual ICollection<Itemdisplayinfo> ItemdisplayinfoHelmetGeosetVis1Navigations { get; set; } = new List<Itemdisplayinfo>();

    public virtual ICollection<Itemdisplayinfo> ItemdisplayinfoHelmetGeosetVis2Navigations { get; set; } = new List<Itemdisplayinfo>();
}
