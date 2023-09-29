// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Loot System
/// </summary>
public partial class AchievementReward
{
    public uint Id { get; set; }

    public uint TitleA { get; set; }

    public uint TitleH { get; set; }

    public uint ItemId { get; set; }

    public uint Sender { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public uint MailTemplateId { get; set; }
}
