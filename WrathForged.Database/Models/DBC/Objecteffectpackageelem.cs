using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Objecteffectpackageelem
{
    public int Id { get; set; }

    public int? ObjectEffectPackageId { get; set; }

    public int? ObjectEffectGroupId { get; set; }

    public int StateType { get; set; }

    public virtual Objecteffectgroup? ObjectEffectGroup { get; set; }

    public virtual Objecteffectpackage? ObjectEffectPackage { get; set; }
}
