using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Holiday
{
    public int Id { get; set; }

    public int Duration1 { get; set; }

    public int Duration2 { get; set; }

    public int Duration3 { get; set; }

    public int Duration4 { get; set; }

    public int Duration5 { get; set; }

    public int Duration6 { get; set; }

    public int Duration7 { get; set; }

    public int Duration8 { get; set; }

    public int Duration9 { get; set; }

    public int Duration10 { get; set; }

    public int Date1 { get; set; }

    public int Date2 { get; set; }

    public int Date3 { get; set; }

    public int Date4 { get; set; }

    public int Date5 { get; set; }

    public int Date6 { get; set; }

    public int Date7 { get; set; }

    public int Date8 { get; set; }

    public int Date9 { get; set; }

    public int Date10 { get; set; }

    public int Date11 { get; set; }

    public int Date12 { get; set; }

    public int Date13 { get; set; }

    public int Date14 { get; set; }

    public int Date15 { get; set; }

    public int Date16 { get; set; }

    public int Date17 { get; set; }

    public int Date18 { get; set; }

    public int Date19 { get; set; }

    public int Date20 { get; set; }

    public int Date21 { get; set; }

    public int Date22 { get; set; }

    public int Date23 { get; set; }

    public int Date24 { get; set; }

    public int Date25 { get; set; }

    public int Date26 { get; set; }

    public int Region { get; set; }

    public int Looping { get; set; }

    public int CalendarFlags1 { get; set; }

    public int CalendarFlags2 { get; set; }

    public int CalendarFlags3 { get; set; }

    public int CalendarFlags4 { get; set; }

    public int CalendarFlags5 { get; set; }

    public int CalendarFlags6 { get; set; }

    public int CalendarFlags7 { get; set; }

    public int CalendarFlags8 { get; set; }

    public int CalendarFlags9 { get; set; }

    public int CalendarFlags10 { get; set; }

    public int? HolidayNameId { get; set; }

    public int? HolidayDescriptionId { get; set; }

    public string? TextureFilename { get; set; }

    public int Priority { get; set; }

    public int CalendarFilterType { get; set; }

    public int Flags { get; set; }

    public virtual Holidaydescription? HolidayDescription { get; set; }

    public virtual Holidayname? HolidayName { get; set; }
}
