using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Currencytype
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int CategoryId { get; set; }

    public int BitIndex { get; set; }
}
