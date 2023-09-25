// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Holidays.dbc")]
    public partial class Holiday : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Duration1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Duration2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Duration3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int Duration4 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int Duration5 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int Duration6 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int Duration7 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int Duration8 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int Duration9 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int Duration10 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int Date1 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int Date2 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int Date3 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int Date4 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int Date5 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int Date6 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int Date7 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int Date8 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32)]
        public int Date9 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32)]
        public int Date10 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int Date11 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
        public int Date12 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.INT32)]
        public int Date13 { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.INT32)]
        public int Date14 { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.INT32)]
        public int Date15 { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.INT32)]
        public int Date16 { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.INT32)]
        public int Date17 { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.INT32)]
        public int Date18 { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.INT32)]
        public int Date19 { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.INT32)]
        public int Date20 { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.INT32)]
        public int Date21 { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.INT32)]
        public int Date22 { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.INT32)]
        public int Date23 { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.INT32)]
        public int Date24 { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.INT32)]
        public int Date25 { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.INT32)]
        public int Date26 { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.INT32)]
        public int Region { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.INT32)]
        public int Looping { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.INT32)]
        public int CalendarFlags1 { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.INT32)]
        public int CalendarFlags2 { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.INT32)]
        public int CalendarFlags3 { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.INT32)]
        public int CalendarFlags4 { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.INT32)]
        public int CalendarFlags5 { get; set; }

        [DBCPropertyBinding(44, DBCBindingType.INT32)]
        public int CalendarFlags6 { get; set; }

        [DBCPropertyBinding(45, DBCBindingType.INT32)]
        public int CalendarFlags7 { get; set; }

        [DBCPropertyBinding(46, DBCBindingType.INT32)]
        public int CalendarFlags8 { get; set; }

        [DBCPropertyBinding(47, DBCBindingType.INT32)]
        public int CalendarFlags9 { get; set; }

        [DBCPropertyBinding(48, DBCBindingType.INT32)]
        public int CalendarFlags10 { get; set; }

        [DBCPropertyBinding(49, DBCBindingType.INT32)]
        public int Flags { get; set; }

        public virtual Holidaydescription? HolidayDescription { get; set; }
        public virtual Holidayname? HolidayName { get; set; }
    }
}
