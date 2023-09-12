using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class AchievementCriterion
{
    public int Id { get; set; }

    public int? AchievementId { get; set; }

    public int Type { get; set; }

    public int AssetId { get; set; }

    public int Quantity { get; set; }

    public int StartEvent { get; set; }

    public int StartAsset { get; set; }

    public int FailEvent { get; set; }

    public int FailAsset { get; set; }

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

    public int Flags { get; set; }

    public int TimerStartEvent { get; set; }

    public int TimerAssetId { get; set; }

    public int TimerTime { get; set; }

    public int UiOrder { get; set; }

    public virtual Achievement? Achievement { get; set; }
}
