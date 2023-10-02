// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellFocusObject.dbc")]
    public partial class Spellfocusobject : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? NameLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING)]
        public string? NameLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING)]
        public string? NameLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING)]
        public string? NameLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING)]
        public string? NameLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING)]
        public string? NameLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING)]
        public string? NameLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING)]
        public string? NameLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING)]
        public string? NameLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING)]
        public string? NameLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING)]
        public string? NameLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING)]
        public string? NameLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING)]
        public string? NameLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING)]
        public string? NameLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? NameLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? NameLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint NameLangMask { get; set; }

        public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
    }
}
