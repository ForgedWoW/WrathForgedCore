// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Worldstateui
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int? AreaId { get; set; }

    public int PhaseShift { get; set; }

    public string? Icon { get; set; }

    public string? StringLangEnUs { get; set; }

    public string? StringLangEnGb { get; set; }

    public string? StringLangKoKr { get; set; }

    public string? StringLangFrFr { get; set; }

    public string? StringLangDeDe { get; set; }

    public string? StringLangEnCn { get; set; }

    public string? StringLangZhCn { get; set; }

    public string? StringLangEnTw { get; set; }

    public string? StringLangZhTw { get; set; }

    public string? StringLangEsEs { get; set; }

    public string? StringLangEsMx { get; set; }

    public string? StringLangRuRu { get; set; }

    public string? StringLangPtPt { get; set; }

    public string? StringLangPtBr { get; set; }

    public string? StringLangItIt { get; set; }

    public string? StringLangUnk { get; set; }

    public uint StringLangMask { get; set; }

    public string? TooltipLangEnUs { get; set; }

    public string? TooltipLangEnGb { get; set; }

    public string? TooltipLangKoKr { get; set; }

    public string? TooltipLangFrFr { get; set; }

    public string? TooltipLangDeDe { get; set; }

    public string? TooltipLangEnCn { get; set; }

    public string? TooltipLangZhCn { get; set; }

    public string? TooltipLangEnTw { get; set; }

    public string? TooltipLangZhTw { get; set; }

    public string? TooltipLangEsEs { get; set; }

    public string? TooltipLangEsMx { get; set; }

    public string? TooltipLangRuRu { get; set; }

    public string? TooltipLangPtPt { get; set; }

    public string? TooltipLangPtBr { get; set; }

    public string? TooltipLangItIt { get; set; }

    public string? TooltipLangUnk { get; set; }

    public uint TooltipLangMask { get; set; }

    public int StateVariable { get; set; }

    public int Type { get; set; }

    public string? DynamicIcon { get; set; }

    public string? DynamicTooltipLangEnUs { get; set; }

    public string? DynamicTooltipLangEnGb { get; set; }

    public string? DynamicTooltipLangKoKr { get; set; }

    public string? DynamicTooltipLangFrFr { get; set; }

    public string? DynamicTooltipLangDeDe { get; set; }

    public string? DynamicTooltipLangEnCn { get; set; }

    public string? DynamicTooltipLangZhCn { get; set; }

    public string? DynamicTooltipLangEnTw { get; set; }

    public string? DynamicTooltipLangZhTw { get; set; }

    public string? DynamicTooltipLangEsEs { get; set; }

    public string? DynamicTooltipLangEsMx { get; set; }

    public string? DynamicTooltipLangRuRu { get; set; }

    public string? DynamicTooltipLangPtPt { get; set; }

    public string? DynamicTooltipLangPtBr { get; set; }

    public string? DynamicTooltipLangItIt { get; set; }

    public string? DynamicTooltipLangUnk { get; set; }

    public uint DynamicTooltipLangMask { get; set; }

    public string? ExtendedUi { get; set; }

    public int ExtendedUistateVariable1 { get; set; }

    public int ExtendedUistateVariable2 { get; set; }

    public int ExtendedUistateVariable3 { get; set; }

    public virtual Areatable? Area { get; set; }

    public virtual Map? Map { get; set; }
}
