using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterFishingstep
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public byte FishingSteps { get; set; }
}
