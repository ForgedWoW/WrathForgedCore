using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gmsurveyquestion
{
    public int Id { get; set; }

    public string? QuestionLangEnUs { get; set; }

    public string? QuestionLangEnGb { get; set; }

    public string? QuestionLangKoKr { get; set; }

    public string? QuestionLangFrFr { get; set; }

    public string? QuestionLangDeDe { get; set; }

    public string? QuestionLangEnCn { get; set; }

    public string? QuestionLangZhCn { get; set; }

    public string? QuestionLangEnTw { get; set; }

    public string? QuestionLangZhTw { get; set; }

    public string? QuestionLangEsEs { get; set; }

    public string? QuestionLangEsMx { get; set; }

    public string? QuestionLangRuRu { get; set; }

    public string? QuestionLangPtPt { get; set; }

    public string? QuestionLangPtBr { get; set; }

    public string? QuestionLangItIt { get; set; }

    public string? QuestionLangUnk { get; set; }

    public uint QuestionLangMask { get; set; }

    public virtual ICollection<Gmsurveyanswer> Gmsurveyanswers { get; set; } = new List<Gmsurveyanswer>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ10Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ1Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ2Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ3Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ4Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ5Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ6Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ7Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ8Navigations { get; set; } = new List<Gmsurveysurvey>();

    public virtual ICollection<Gmsurveysurvey> GmsurveysurveyQ9Navigations { get; set; } = new List<Gmsurveysurvey>();
}
