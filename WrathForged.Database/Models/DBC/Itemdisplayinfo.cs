// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Itemdisplayinfo.dbc")]
    public partial class Itemdisplayinfo : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? ModelName1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING)]
        public string? ModelName2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING)]
        public string? ModelTexture1 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING)]
        public string? ModelTexture2 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING)]
        public string? InventoryIcon1 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING)]
        public string? InventoryIcon2 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int GeosetGroup1 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int GeosetGroup2 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int GeosetGroup3 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int SpellVisualId { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int? GroupSoundIndex { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int? HelmetGeosetVis1 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int? HelmetGeosetVis2 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? Texture1 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? Texture2 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING)]
        public string? Texture3 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING)]
        public string? Texture4 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING)]
        public string? Texture5 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING)]
        public string? Texture6 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.STRING)]
        public string? Texture7 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.STRING)]
        public string? Texture8 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.INT32)]
        public int? ItemVisual { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.INT32)]
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
}
