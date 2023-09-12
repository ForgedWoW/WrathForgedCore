using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Mailtemplate
{
    public int Id { get; set; }

    public string? SubjectLangEnUs { get; set; }

    public string? SubjectLangEnGb { get; set; }

    public string? SubjectLangKoKr { get; set; }

    public string? SubjectLangFrFr { get; set; }

    public string? SubjectLangDeDe { get; set; }

    public string? SubjectLangEnCn { get; set; }

    public string? SubjectLangZhCn { get; set; }

    public string? SubjectLangEnTw { get; set; }

    public string? SubjectLangZhTw { get; set; }

    public string? SubjectLangEsEs { get; set; }

    public string? SubjectLangEsMx { get; set; }

    public string? SubjectLangRuRu { get; set; }

    public string? SubjectLangPtPt { get; set; }

    public string? SubjectLangPtBr { get; set; }

    public string? SubjectLangItIt { get; set; }

    public string? SubjectLangUnk { get; set; }

    public uint SubjectLangMask { get; set; }

    public string? BodyLangEnUs { get; set; }

    public string? BodyLangEnGb { get; set; }

    public string? BodyLangKoKr { get; set; }

    public string? BodyLangFrFr { get; set; }

    public string? BodyLangDeDe { get; set; }

    public string? BodyLangEnCn { get; set; }

    public string? BodyLangZhCn { get; set; }

    public string? BodyLangEnTw { get; set; }

    public string? BodyLangZhTw { get; set; }

    public string? BodyLangEsEs { get; set; }

    public string? BodyLangEsMx { get; set; }

    public string? BodyLangRuRu { get; set; }

    public string? BodyLangPtPt { get; set; }

    public string? BodyLangPtBr { get; set; }

    public string? BodyLangItIt { get; set; }

    public string? BodyLangUnk { get; set; }

    public uint BodyLangMask { get; set; }
}
