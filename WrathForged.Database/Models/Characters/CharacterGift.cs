using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterGift
{
    public uint Guid { get; set; }

    public uint ItemGuid { get; set; }

    public uint Entry { get; set; }

    public uint Flags { get; set; }
}
