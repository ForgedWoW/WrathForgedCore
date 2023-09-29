// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class MailItem
{
    public uint MailId { get; set; }

    public uint ItemGuid { get; set; }

    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint Receiver { get; set; }
}
