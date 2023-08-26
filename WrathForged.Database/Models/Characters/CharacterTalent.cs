using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterTalent
{
    public uint Guid { get; set; }

    public uint Spell { get; set; }

    public byte TalentGroup { get; set; }
}
