// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class GuildBankRight
{
    public uint Guildid { get; set; }

    public byte TabId { get; set; }

    public byte Rid { get; set; }

    public byte Gbright { get; set; }

    public uint SlotPerDay { get; set; }
}
