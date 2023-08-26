using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CalendarInvite
{
    public ulong Id { get; set; }

    public ulong Event { get; set; }

    public uint Invitee { get; set; }

    public uint Sender { get; set; }

    public byte Status { get; set; }

    public uint Statustime { get; set; }

    public byte Rank { get; set; }

    public string Text { get; set; } = null!;
}
