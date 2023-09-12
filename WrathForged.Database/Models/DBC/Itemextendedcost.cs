using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemextendedcost
{
    public int Id { get; set; }

    public int HonorPoints { get; set; }

    public int ArenaPoints { get; set; }

    public int ArenaBracket { get; set; }

    public int ItemId1 { get; set; }

    public int ItemId2 { get; set; }

    public int ItemId3 { get; set; }

    public int ItemId4 { get; set; }

    public int ItemId5 { get; set; }

    public int ItemCount1 { get; set; }

    public int ItemCount2 { get; set; }

    public int ItemCount3 { get; set; }

    public int ItemCount4 { get; set; }

    public int ItemCount5 { get; set; }

    public int RequiredArenaRating { get; set; }

    public int? ItemPurchaseGroup { get; set; }

    public virtual Itempurchasegroup? ItemPurchaseGroupNavigation { get; set; }
}
