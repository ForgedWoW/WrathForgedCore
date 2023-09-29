// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
