// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("TaxiPath.dbc")]
public partial class Taxipath : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? FromTaxiNode { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? ToTaxiNode { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Cost { get; set; }

    public virtual Taxinode? FromTaxiNodeNavigation { get; set; }
    public virtual ICollection<Loadingscreentaxispline> Loadingscreentaxisplines { get; set; } = new List<Loadingscreentaxispline>();
    public virtual ICollection<Taxipathnode> Taxipathnodes { get; set; } = new List<Taxipathnode>();
    public virtual Taxinode? ToTaxiNodeNavigation { get; set; }
}
