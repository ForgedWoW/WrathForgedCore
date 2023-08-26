using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CalendarEvent
{
    public ulong Id { get; set; }

    public uint Creator { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public byte Type { get; set; }

    public int Dungeon { get; set; }

    public uint Eventtime { get; set; }

    public uint Flags { get; set; }

    public uint Time2 { get; set; }
}
