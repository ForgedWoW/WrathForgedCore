using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameobjectQuestitem
{
    public uint GameObjectEntry { get; set; }

    public uint Idx { get; set; }

    public uint ItemId { get; set; }

    public int? VerifiedBuild { get; set; }
}
