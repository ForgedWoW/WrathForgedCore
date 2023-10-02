// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Startup_Strings.dbc")]
    public partial class StartupString : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING)]
        public string? Name { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING)]
        public string? MessageLangEnUs { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING)]
        public string? MessageLangEnGb { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING)]
        public string? MessageLangKoKr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING)]
        public string? MessageLangFrFr { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING)]
        public string? MessageLangDeDe { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING)]
        public string? MessageLangEnCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING)]
        public string? MessageLangZhCn { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING)]
        public string? MessageLangEnTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING)]
        public string? MessageLangZhTw { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING)]
        public string? MessageLangEsEs { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING)]
        public string? MessageLangEsMx { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING)]
        public string? MessageLangRuRu { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING)]
        public string? MessageLangPtPt { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING)]
        public string? MessageLangPtBr { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING)]
        public string? MessageLangItIt { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.STRING)]
        public string? MessageLangUnk { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.UINT32)]
        public uint MessageLangMask { get; set; }
    }
}
