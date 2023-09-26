// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("MailTemplate.dbc")]
    public partial class Mailtemplate : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
        public string? SubjectLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint SubjectLangMask { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEnUs { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEnGb { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangKoKr { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangFrFr { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangDeDe { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEnCn { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangZhCn { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEnTw { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangZhTw { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEsEs { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangEsMx { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangRuRu { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangPtPt { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangPtBr { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangItIt { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.STRING, Nullable = true)]
        public string? BodyLangUnk { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.UINT32)]
        public uint BodyLangMask { get; set; }
    }
}
