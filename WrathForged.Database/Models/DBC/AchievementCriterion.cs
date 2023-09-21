// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Achievement_Criteria.dbc")]
public partial class AchievementCriterion
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int? AchievementId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Type { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int AssetId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Quantity { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int StartEvent { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int StartAsset { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int FailEvent { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int FailAsset { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public uint DescriptionLangMask { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int TimerStartEvent { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int TimerAssetId { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int TimerTime { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int UiOrder { get; set; }

    public virtual Achievement? Achievement { get; set; }
}