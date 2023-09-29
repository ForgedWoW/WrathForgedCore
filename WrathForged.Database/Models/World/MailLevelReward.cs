// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Mail System
/// </summary>
public partial class MailLevelReward
{
    public byte Level { get; set; }

    public uint RaceMask { get; set; }

    public uint MailTemplateId { get; set; }

    public uint SenderEntry { get; set; }
}
