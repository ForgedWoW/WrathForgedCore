using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GossipMenuOptionLocale
{
    public ushort MenuId { get; set; }

    public ushort OptionId { get; set; }

    public string Locale { get; set; } = null!;

    public string? OptionText { get; set; }

    public string? BoxText { get; set; }
}
