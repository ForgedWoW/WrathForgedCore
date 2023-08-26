using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEvent
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    /// <summary>
    /// Absolute start date, the event will never start before
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Absolute end date, the event will never start after
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Delay in minutes between occurences of the event
    /// </summary>
    public ulong Occurence { get; set; }

    /// <summary>
    /// Length in minutes of the event
    /// </summary>
    public ulong Length { get; set; }

    /// <summary>
    /// Client side holiday id
    /// </summary>
    public uint Holiday { get; set; }

    public byte HolidayStage { get; set; }

    /// <summary>
    /// Description of the event displayed in console
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 0 if normal event, 1 if world event
    /// </summary>
    public byte WorldEvent { get; set; }

    /// <summary>
    /// 0 dont announce, 1 announce, 2 value from config
    /// </summary>
    public byte? Announce { get; set; }
}
