// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.DBC;

public partial class Achievement
{
    public int Id { get; set; }

    public int Faction { get; set; }

    public int? InstanceId { get; set; }

    public int? Supercedes { get; set; }

    public string? TitleLangEnUs { get; set; }

    public string? TitleLangEnGb { get; set; }

    public string? TitleLangKoKr { get; set; }

    public string? TitleLangFrFr { get; set; }

    public string? TitleLangDeDe { get; set; }

    public string? TitleLangEnCn { get; set; }

    public string? TitleLangZhCn { get; set; }

    public string? TitleLangEnTw { get; set; }

    public string? TitleLangZhTw { get; set; }

    public string? TitleLangEsEs { get; set; }

    public string? TitleLangEsMx { get; set; }

    public string? TitleLangRuRu { get; set; }

    public string? TitleLangPtPt { get; set; }

    public string? TitleLangPtBr { get; set; }

    public string? TitleLangItIt { get; set; }

    public string? TitleLangUnk { get; set; }

    public uint TitleLangMask { get; set; }

    public string? DescriptionLangEnUs { get; set; }

    public string? DescriptionLangEnGb { get; set; }

    public string? DescriptionLangKoKr { get; set; }

    public string? DescriptionLangFrFr { get; set; }

    public string? DescriptionLangDeDe { get; set; }

    public string? DescriptionLangEnCn { get; set; }

    public string? DescriptionLangZhCn { get; set; }

    public string? DescriptionLangEnTw { get; set; }

    public string? DescriptionLangZhTw { get; set; }

    public string? DescriptionLangEsEs { get; set; }

    public string? DescriptionLangEsMx { get; set; }

    public string? DescriptionLangRuRu { get; set; }

    public string? DescriptionLangPtPt { get; set; }

    public string? DescriptionLangPtBr { get; set; }

    public string? DescriptionLangItIt { get; set; }

    public string? DescriptionLangUnk { get; set; }

    public uint DescriptionLangMask { get; set; }

    public int? Category { get; set; }

    public int Points { get; set; }

    public int UiOrder { get; set; }

    public int Flags { get; set; }

    public int? IconId { get; set; }

    public string? RewardLangEnUs { get; set; }

    public string? RewardLangEnGb { get; set; }

    public string? RewardLangKoKr { get; set; }

    public string? RewardLangFrFr { get; set; }

    public string? RewardLangDeDe { get; set; }

    public string? RewardLangEnCn { get; set; }

    public string? RewardLangZhCn { get; set; }

    public string? RewardLangEnTw { get; set; }

    public string? RewardLangZhTw { get; set; }

    public string? RewardLangEsEs { get; set; }

    public string? RewardLangEsMx { get; set; }

    public string? RewardLangRuRu { get; set; }

    public string? RewardLangPtPt { get; set; }

    public string? RewardLangPtBr { get; set; }

    public string? RewardLangItIt { get; set; }

    public string? RewardLangUnk { get; set; }

    public uint RewardLangMask { get; set; }

    public int MinimumCriteria { get; set; }

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