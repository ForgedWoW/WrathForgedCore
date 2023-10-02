// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellMechanic.dbc")]
    public partial class Spellmechanic : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
        public string? StateNameLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint StateNameLangMask { get; set; }

        public virtual ICollection<Spell> SpellEffectMechanic1Navigations { get; set; } = new List<Spell>();
        public virtual ICollection<Spell> SpellEffectMechanic2Navigations { get; set; } = new List<Spell>();
        public virtual ICollection<Spell> SpellEffectMechanic3Navigations { get; set; } = new List<Spell>();
        public virtual ICollection<Spell> SpellMechanicNavigations { get; set; } = new List<Spell>();
    }
}
