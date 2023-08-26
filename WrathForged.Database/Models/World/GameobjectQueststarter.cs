using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameobjectQueststarter
{
    public uint Id { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }
}
