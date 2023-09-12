using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Paperdollitemframe
{
    public int Id { get; set; }

    public string? ItemButtonName { get; set; }

    public string? SlotIcon { get; set; }

    public int SlotNumber { get; set; }
}
