﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterAchievement
{
    public uint Guid { get; set; }

    public ushort Achievement { get; set; }

    public uint Date { get; set; }
}
