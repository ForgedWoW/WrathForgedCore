using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemdisplayinfo
{
    public int Id { get; set; }

    public string? ModelName1 { get; set; }

    public string? ModelName2 { get; set; }

    public string? ModelTexture1 { get; set; }

    public string? ModelTexture2 { get; set; }

    public string? InventoryIcon1 { get; set; }

    public string? InventoryIcon2 { get; set; }

    public int GeosetGroup1 { get; set; }

    public int GeosetGroup2 { get; set; }

    public int GeosetGroup3 { get; set; }

    public int Flags { get; set; }

    public int SpellVisualId { get; set; }

    public int? GroupSoundIndex { get; set; }

    public int? HelmetGeosetVis1 { get; set; }

    public int? HelmetGeosetVis2 { get; set; }

    public string? Texture1 { get; set; }

    public string? Texture2 { get; set; }

    public string? Texture3 { get; set; }

    public string? Texture4 { get; set; }

    public string? Texture5 { get; set; }

    public string? Texture6 { get; set; }

    public string? Texture7 { get; set; }

    public string? Texture8 { get; set; }

    public int? ItemVisual { get; set; }

    public int ParticleColorId { get; set; }

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay10Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay11Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay1Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay2Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay3Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay4Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay5Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay6Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay7Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay8Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual ICollection<Creaturedisplayinfoextra> CreaturedisplayinfoextraNpcitemDisplay9Navigations { get; set; } = new List<Creaturedisplayinfoextra>();

    public virtual Itemgroupsound? GroupSoundIndexNavigation { get; set; }

    public virtual Helmetgeosetvisdatum? HelmetGeosetVis1Navigation { get; set; }

    public virtual Helmetgeosetvisdatum? HelmetGeosetVis2Navigation { get; set; }

    public virtual Itemvisual? ItemVisualNavigation { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
