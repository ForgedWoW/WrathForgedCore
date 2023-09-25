// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ItemClass.dbc")]
    public partial class Itemclass : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int ClassId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int SubclassMapId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING)]
        public string? ClassNameLangEnUs { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING)]
        public string? ClassNameLangEnGb { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING)]
        public string? ClassNameLangKoKr { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING)]
        public string? ClassNameLangFrFr { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING)]
        public string? ClassNameLangDeDe { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING)]
        public string? ClassNameLangEnCn { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING)]
        public string? ClassNameLangZhCn { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING)]
        public string? ClassNameLangEnTw { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING)]
        public string? ClassNameLangZhTw { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING)]
        public string? ClassNameLangEsEs { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING)]
        public string? ClassNameLangEsMx { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? ClassNameLangRuRu { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? ClassNameLangPtPt { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING)]
        public string? ClassNameLangPtBr { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING)]
        public string? ClassNameLangItIt { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING)]
        public string? ClassNameLangUnk { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.UINT32)]
        public uint ClassNameLangMask { get; set; }

        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
