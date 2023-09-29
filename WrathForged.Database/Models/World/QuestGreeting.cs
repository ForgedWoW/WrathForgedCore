// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class QuestGreeting
{
    public uint Id { get; set; }

    public byte Type { get; set; }

    public ushort GreetEmoteType { get; set; }

    public uint GreetEmoteDelay { get; set; }

    public string? Greeting { get; set; }

    public int? VerifiedBuild { get; set; }
}
