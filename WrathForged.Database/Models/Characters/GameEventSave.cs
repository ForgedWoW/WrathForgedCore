using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class GameEventSave
{
    public byte EventEntry { get; set; }

    public byte State { get; set; }

    public uint NextStart { get; set; }
}
