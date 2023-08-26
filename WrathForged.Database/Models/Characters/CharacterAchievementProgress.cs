using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterAchievementProgress
{
    public uint Guid { get; set; }

    public ushort Criteria { get; set; }

    public uint Counter { get; set; }

    public uint Date { get; set; }
}
