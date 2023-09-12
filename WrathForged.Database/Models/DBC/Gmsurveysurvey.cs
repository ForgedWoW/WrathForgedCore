using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gmsurveysurvey
{
    public int Id { get; set; }

    public int? Q1 { get; set; }

    public int? Q2 { get; set; }

    public int? Q3 { get; set; }

    public int? Q4 { get; set; }

    public int? Q5 { get; set; }

    public int? Q6 { get; set; }

    public int? Q7 { get; set; }

    public int? Q8 { get; set; }

    public int? Q9 { get; set; }

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
