using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterArenaStat
{
    public uint Guid { get; set; }

    public byte Slot { get; set; }

    public ushort MatchMakerRating { get; set; }
}
