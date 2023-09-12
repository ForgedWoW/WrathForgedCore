using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gmsurveyanswer
{
    public int Id { get; set; }

    public int SortIndex { get; set; }

    public int? GmsurveyQuestionId { get; set; }

    public string? AnswerLangEnUs { get; set; }

    public string? AnswerLangEnGb { get; set; }

    public string? AnswerLangKoKr { get; set; }

    public string? AnswerLangFrFr { get; set; }

    public string? AnswerLangDeDe { get; set; }

    public string? AnswerLangEnCn { get; set; }

    public string? AnswerLangZhCn { get; set; }

    public string? AnswerLangEnTw { get; set; }

    public string? AnswerLangZhTw { get; set; }

    public string? AnswerLangEsEs { get; set; }

    public string? AnswerLangEsMx { get; set; }

    public string? AnswerLangRuRu { get; set; }

    public string? AnswerLangPtPt { get; set; }

    public string? AnswerLangPtBr { get; set; }

    public string? AnswerLangItIt { get; set; }

    public string? AnswerLangUnk { get; set; }

    public uint AnswerLangMask { get; set; }

    public virtual Gmsurveyquestion? GmsurveyQuestion { get; set; }
}
