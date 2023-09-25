// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("GMSurveyQuestions.dbc")]
    public partial class Gmsurveyquestion : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEnUs { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEnGb { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangKoKr { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangFrFr { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangDeDe { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEnCn { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangZhCn { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEnTw { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangZhTw { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEsEs { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangEsMx { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangRuRu { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangPtPt { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangPtBr { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangItIt { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
        public string? QuestionLangUnk { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
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
}
