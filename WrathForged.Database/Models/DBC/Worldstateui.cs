// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("WorldStateUI.dbc")]
    public partial class Worldstateui : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? MapId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? AreaId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int PhaseShift { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
        public string? Icon { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEnUs { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEnGb { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangKoKr { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangFrFr { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangDeDe { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEnCn { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangZhCn { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEnTw { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangZhTw { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEsEs { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangEsMx { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangRuRu { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangPtPt { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangPtBr { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangItIt { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
        public string? StringLangUnk { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.UINT32)]
        public uint StringLangMask { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEnUs { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEnGb { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangKoKr { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangFrFr { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangDeDe { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEnCn { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangZhCn { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEnTw { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangZhTw { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEsEs { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangEsMx { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangRuRu { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangPtPt { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangPtBr { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangItIt { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.STRING, Nullable = true)]
        public string? TooltipLangUnk { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.UINT32)]
        public uint TooltipLangMask { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.INT32)]
        public int StateVariable { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.INT32)]
        public int Type { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicIcon { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEnUs { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEnGb { get; set; }

        [DBCPropertyBinding(44, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangKoKr { get; set; }

        [DBCPropertyBinding(45, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangFrFr { get; set; }

        [DBCPropertyBinding(46, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangDeDe { get; set; }

        [DBCPropertyBinding(47, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEnCn { get; set; }

        [DBCPropertyBinding(48, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangZhCn { get; set; }

        [DBCPropertyBinding(49, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEnTw { get; set; }

        [DBCPropertyBinding(50, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangZhTw { get; set; }

        [DBCPropertyBinding(51, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEsEs { get; set; }

        [DBCPropertyBinding(52, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangEsMx { get; set; }

        [DBCPropertyBinding(53, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangRuRu { get; set; }

        [DBCPropertyBinding(54, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangPtPt { get; set; }

        [DBCPropertyBinding(55, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangPtBr { get; set; }

        [DBCPropertyBinding(56, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangItIt { get; set; }

        [DBCPropertyBinding(57, DBCBindingType.STRING, Nullable = true)]
        public string? DynamicTooltipLangUnk { get; set; }

        [DBCPropertyBinding(58, DBCBindingType.UINT32)]
        public uint DynamicTooltipLangMask { get; set; }

        [DBCPropertyBinding(59, DBCBindingType.STRING, Nullable = true)]
        public string? ExtendedUi { get; set; }

        [DBCPropertyBinding(60, DBCBindingType.INT32)]
        public int ExtendedUistateVariable1 { get; set; }

        [DBCPropertyBinding(61, DBCBindingType.INT32)]
        public int ExtendedUistateVariable2 { get; set; }

        [DBCPropertyBinding(62, DBCBindingType.INT32)]
        public int ExtendedUistateVariable3 { get; set; }

        public virtual Areatable? Area { get; set; }
        public virtual Map? Map { get; set; }
    }
}
