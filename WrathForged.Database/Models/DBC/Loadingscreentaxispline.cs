using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Loadingscreentaxispline
{
    public int Id { get; set; }

    public int? PathId { get; set; }

    public float Locx1 { get; set; }

    public float Locx2 { get; set; }

    public float Locx3 { get; set; }

    public float Locx4 { get; set; }

    public float Locx5 { get; set; }

    public float Locx6 { get; set; }

    public float Locx7 { get; set; }

    public float Locx8 { get; set; }

    public float Locy1 { get; set; }

    public float Locy2 { get; set; }

    public float Locy3 { get; set; }

    public float Locy4 { get; set; }

    public float Locy5 { get; set; }

    public float Locy6 { get; set; }

    public float Locy7 { get; set; }

    public float Locy8 { get; set; }

    public int LegIndex { get; set; }

    public virtual Taxipath? Path { get; set; }
}
