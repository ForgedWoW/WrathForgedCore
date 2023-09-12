using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Lock
{
    public int Id { get; set; }

    public int? Type1 { get; set; }

    public int? Type2 { get; set; }

    public int? Type3 { get; set; }

    public int? Type4 { get; set; }

    public int? Type5 { get; set; }

    public int? Type6 { get; set; }

    public int? Type7 { get; set; }

    public int? Type8 { get; set; }

    public int Index1 { get; set; }

    public int Index2 { get; set; }

    public int Index3 { get; set; }

    public int Index4 { get; set; }

    public int Index5 { get; set; }

    public int Index6 { get; set; }

    public int Index7 { get; set; }

    public int Index8 { get; set; }

    public int Skill1 { get; set; }

    public int Skill2 { get; set; }

    public int Skill3 { get; set; }

    public int Skill4 { get; set; }

    public int Skill5 { get; set; }

    public int Skill6 { get; set; }

    public int Skill7 { get; set; }

    public int Skill8 { get; set; }

    public int Action1 { get; set; }

    public int Action2 { get; set; }

    public int Action3 { get; set; }

    public int Action4 { get; set; }

    public int Action5 { get; set; }

    public int Action6 { get; set; }

    public int Action7 { get; set; }

    public int Action8 { get; set; }

    public virtual Locktype? Type1Navigation { get; set; }

    public virtual Locktype? Type2Navigation { get; set; }

    public virtual Locktype? Type3Navigation { get; set; }

    public virtual Locktype? Type4Navigation { get; set; }

    public virtual Locktype? Type5Navigation { get; set; }

    public virtual Locktype? Type6Navigation { get; set; }

    public virtual Locktype? Type7Navigation { get; set; }

    public virtual Locktype? Type8Navigation { get; set; }
}
