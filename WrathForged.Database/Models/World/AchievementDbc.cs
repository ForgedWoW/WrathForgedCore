// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class AchievementDbc
{
    public uint Id { get; set; }

    public int RequiredFaction { get; set; }

    public int MapId { get; set; }

    public uint Points { get; set; }

    public uint Flags { get; set; }

    public uint Count { get; set; }

    public uint RefAchievement { get; set; }
}
