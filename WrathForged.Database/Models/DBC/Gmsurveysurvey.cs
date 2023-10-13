// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("GMSurveySurveys.dbc")]
public partial class Gmsurveysurvey : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Q1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? Q2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? Q3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? Q4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? Q5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? Q6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? Q7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? Q8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? Q9 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? Q10 { get; set; }

    public virtual ICollection<Gmsurveycurrentsurvey> Gmsurveycurrentsurveys { get; set; } = new List<Gmsurveycurrentsurvey>();
    public virtual Gmsurveyquestion? Q10Navigation { get; set; }
    public virtual Gmsurveyquestion? Q1Navigation { get; set; }
    public virtual Gmsurveyquestion? Q2Navigation { get; set; }
    public virtual Gmsurveyquestion? Q3Navigation { get; set; }
    public virtual Gmsurveyquestion? Q4Navigation { get; set; }
    public virtual Gmsurveyquestion? Q5Navigation { get; set; }
    public virtual Gmsurveyquestion? Q6Navigation { get; set; }
    public virtual Gmsurveyquestion? Q7Navigation { get; set; }
    public virtual Gmsurveyquestion? Q8Navigation { get; set; }
    public virtual Gmsurveyquestion? Q9Navigation { get; set; }
}
