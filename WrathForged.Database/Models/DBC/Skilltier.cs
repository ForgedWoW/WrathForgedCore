using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Skilltier
{
    public int Id { get; set; }

    public int Cost1 { get; set; }

    public int Cost2 { get; set; }

    public int Cost3 { get; set; }

    public int Cost4 { get; set; }

    public int Cost5 { get; set; }

    public int Cost6 { get; set; }

    public int Cost7 { get; set; }

    public int Cost8 { get; set; }

    public int Cost9 { get; set; }

    public int Cost10 { get; set; }

    public int Cost11 { get; set; }

    public int Cost12 { get; set; }

    public int Cost13 { get; set; }

    public int Cost14 { get; set; }

    public int Cost15 { get; set; }

    public int Cost16 { get; set; }

    public int Value1 { get; set; }

    public int Value2 { get; set; }

    public int Value3 { get; set; }

    public int Value4 { get; set; }

    public int Value5 { get; set; }

    public int Value6 { get; set; }

    public int Value7 { get; set; }

    public int Value8 { get; set; }

    public int Value9 { get; set; }

    public int Value10 { get; set; }

    public int Value11 { get; set; }

    public int Value12 { get; set; }

    public int Value13 { get; set; }

    public int Value14 { get; set; }

    public int Value15 { get; set; }

    public int Value16 { get; set; }

    public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();
}
