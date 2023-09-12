using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gmsurveycurrentsurvey
{
    public int Id { get; set; }

    public int? GmsurveyId { get; set; }

    public virtual Gmsurveysurvey? Gmsurvey { get; set; }
}
