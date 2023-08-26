using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class HolidayDate
{
    public uint Id { get; set; }

    public byte DateId { get; set; }

    public uint DateValue { get; set; }

    public uint HolidayDuration { get; set; }
}
