// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Achievement.dbc")]
public partial class Achievement : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, DefaultValue = -1)]
    public int Faction { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, DefaultValue = -1)]
    public int? InstanceId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? Supercedes { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? TitleLangEnUs { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? TitleLangEnGb { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? TitleLangKoKr { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? TitleLangFrFr { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? TitleLangDeDe { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? TitleLangEnCn { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? TitleLangZhCn { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? TitleLangEnTw { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? TitleLangZhTw { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? TitleLangEsEs { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? TitleLangEsMx { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? TitleLangRuRu { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? TitleLangPtPt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? TitleLangPtBr { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? TitleLangItIt { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? TitleLangUnk { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.UINT32)]
    public uint TitleLangMask { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.UINT32)]
    public uint DescriptionLangMask { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32)]
    public int? Category { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.INT32)]
    public int Points { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.INT32)]
    public int UiOrder { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.INT32, Nullable = true)]
    public int? IconId { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? RewardLangEnUs { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? RewardLangEnGb { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? RewardLangKoKr { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? RewardLangFrFr { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING)]
    public string? RewardLangDeDe { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? RewardLangEnCn { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? RewardLangZhCn { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? RewardLangEnTw { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.STRING)]
    public string? RewardLangZhTw { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.STRING)]
    public string? RewardLangEsEs { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.STRING)]
    public string? RewardLangEsMx { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.STRING)]
    public string? RewardLangRuRu { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.STRING)]
    public string? RewardLangPtPt { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.STRING)]
    public string? RewardLangPtBr { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.STRING)]
    public string? RewardLangItIt { get; set; }

    [DBCPropertyBinding(58, DBCBindingType.STRING)]
    public string? RewardLangUnk { get; set; }

    [DBCPropertyBinding(59, DBCBindingType.UINT32)]
    public uint RewardLangMask { get; set; }

    [DBCPropertyBinding(60, DBCBindingType.INT32)]
    public int MinimumCriteria { get; set; }

    [DBCPropertyBinding(61, DBCBindingType.INT32, Nullable = true)]
    public int? SharesCriteria { get; set; }

    public virtual ICollection<AchievementCriterion> AchievementCriteria { get; set; } = new List<AchievementCriterion>();

    public virtual AchievementCategory? CategoryNavigation { get; set; }

    public virtual Spellicon? Icon { get; set; }

    public virtual Map? Instance { get; set; }

    public virtual ICollection<Achievement> InverseSharesCriteriaNavigation { get; set; } = new List<Achievement>();

    public virtual ICollection<Achievement> InverseSupercedesNavigation { get; set; } = new List<Achievement>();

    public virtual Achievement? SharesCriteriaNavigation { get; set; }

    public virtual Achievement? SupercedesNavigation { get; set; }
}