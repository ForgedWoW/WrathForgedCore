// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellItemEnchantment.dbc")]
    public partial class Spellitemenchantment : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Charges { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? Effect1 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? Effect2 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? Effect3 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int EffectPointsMin1 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int EffectPointsMin2 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int EffectPointsMin3 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int EffectPointsMax1 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int EffectPointsMax2 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int EffectPointsMax3 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int EffectArg1 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int EffectArg2 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int EffectArg3 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING)]
        public string? NameLangEnUs { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? NameLangEnGb { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? NameLangKoKr { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING)]
        public string? NameLangFrFr { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING)]
        public string? NameLangDeDe { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING)]
        public string? NameLangEnCn { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING)]
        public string? NameLangZhCn { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.STRING)]
        public string? NameLangEnTw { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.STRING)]
        public string? NameLangZhTw { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.STRING)]
        public string? NameLangEsEs { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.STRING)]
        public string? NameLangEsMx { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.STRING)]
        public string? NameLangRuRu { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.STRING)]
        public string? NameLangPtPt { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.STRING)]
        public string? NameLangPtBr { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.STRING)]
        public string? NameLangItIt { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.STRING)]
        public string? NameLangUnk { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.UINT32)]
        public uint NameLangMask { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.INT32, Nullable = true)]
        public int? ItemVisual { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.INT32, Nullable = true)]
        public int? SrcItemId { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.INT32, Nullable = true)]
        public int? ConditionId { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.INT32, Nullable = true)]
        public int? RequiredSkillId { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.INT32)]
        public int RequiredSkillRank { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.INT32)]
        public int MinLevel { get; set; }

        // Navigation properties
        public virtual Spellitemenchantmentcondition? Condition { get; set; }
        public virtual Spelldispeltype? Effect1Navigation { get; set; }
        public virtual Spelldispeltype? Effect2Navigation { get; set; }
        public virtual Spelldispeltype? Effect3Navigation { get; set; }
        public virtual ICollection<Gemproperty> Gemproperties { get; set; } = new List<Gemproperty>();
        public virtual Itemvisual? ItemVisualNavigation { get; set; }
        public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment1Navigations { get; set; } = new List<Itemrandomproperty>();
        public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment2Navigations { get; set; } = new List<Itemrandomproperty>();
        public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment3Navigations { get; set; } = new List<Itemrandomproperty>();
        public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment4Navigations { get; set; } = new List<Itemrandomproperty>();
        public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment5Navigations { get; set; } = new List<Itemrandomproperty>();
        public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment1Navigations { get; set; } = new List<Itemrandomsuffix>();
        public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment2Navigations { get; set; } = new List<Itemrandomsuffix>();
        public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment3Navigations { get; set; } = new List<Itemrandomsuffix>();
        public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment4Navigations { get; set; } = new List<Itemrandomsuffix>();
        public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment5Navigations { get; set; } = new List<Itemrandomsuffix>();
        public virtual Skillline? RequiredSkill { get; set; }
        public virtual Item? SrcItem { get; set; }
    }
}
