using System;
using System.Collections.Generic;
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CreatureDisplayInfoExtra.dbc")]
public partial class Creaturedisplayinfoextra
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? DisplayRaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int DisplaySexId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int SkinId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int FaceId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int HairStyleId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int HairColorId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int FacialHairId { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay1 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay2 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay3 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay4 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay5 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay6 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay7 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay8 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay9 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay10 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
    public int? NpcitemDisplay11 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING, DefaultValue = null)]
    public string? BakeName { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual Chrrace? DisplayRace { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay10Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay11Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay1Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay2Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay3Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay4Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay5Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay6Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay7Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay8Navigation { get; set; }

    public virtual Itemdisplayinfo? NpcitemDisplay9Navigation { get; set; }
}
