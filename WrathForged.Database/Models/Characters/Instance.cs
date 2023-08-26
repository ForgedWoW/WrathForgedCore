using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class Instance
{
    public uint Id { get; set; }

    public ushort Map { get; set; }

    public ulong Resettime { get; set; }

    public byte Difficulty { get; set; }

    public uint CompletedEncounters { get; set; }

    public string Data { get; set; } = null!;
}
