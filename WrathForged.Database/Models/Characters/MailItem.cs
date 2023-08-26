using System;
using System.Collections.Generic;

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
