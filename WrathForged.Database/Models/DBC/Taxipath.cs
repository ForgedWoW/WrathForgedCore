// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
