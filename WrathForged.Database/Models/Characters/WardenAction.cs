using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class WardenAction
{
    public ushort WardenId { get; set; }

    public byte? Action { get; set; }
}
