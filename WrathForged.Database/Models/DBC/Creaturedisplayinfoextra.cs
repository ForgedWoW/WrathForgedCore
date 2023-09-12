using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Creaturedisplayinfoextra
{
    public int Id { get; set; }

    public int? DisplayRaceId { get; set; }

    public int DisplaySexId { get; set; }

    public int SkinId { get; set; }

    public int FaceId { get; set; }

    public int HairStyleId { get; set; }

    public int HairColorId { get; set; }

    public int FacialHairId { get; set; }

    public int? NpcitemDisplay1 { get; set; }

    public int? NpcitemDisplay2 { get; set; }

    public int? NpcitemDisplay3 { get; set; }

    public int? NpcitemDisplay4 { get; set; }

    public int? NpcitemDisplay5 { get; set; }

    public int? NpcitemDisplay6 { get; set; }

    public int? NpcitemDisplay7 { get; set; }

    public int? NpcitemDisplay8 { get; set; }

    public int? NpcitemDisplay9 { get; set; }

    public int? NpcitemDisplay10 { get; set; }

    public int? NpcitemDisplay11 { get; set; }

    public int Flags { get; set; }

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
