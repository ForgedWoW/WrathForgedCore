using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Taxipath
{
    public int Id { get; set; }

    public int? FromTaxiNode { get; set; }

    public int? ToTaxiNode { get; set; }

    public int Cost { get; set; }

    public virtual Taxinode? FromTaxiNodeNavigation { get; set; }

    public virtual ICollection<Loadingscreentaxispline> Loadingscreentaxisplines { get; set; } = new List<Loadingscreentaxispline>();

    public virtual ICollection<Taxipathnode> Taxipathnodes { get; set; } = new List<Taxipathnode>();

    public virtual Taxinode? ToTaxiNodeNavigation { get; set; }
}
