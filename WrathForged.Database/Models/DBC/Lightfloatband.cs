// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("LightFloatBand.dbc")]
    public partial class Lightfloatband : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int Num { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Time1 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int Time2 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int Time3 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int Time4 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int Time5 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int Time6 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int Time7 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int Time8 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int Time9 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int Time10 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int Time11 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int Time12 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int Time13 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int Time14 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int Time15 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int Time16 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.FLOAT)]
        public float Data1 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.FLOAT)]
        public float Data2 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.FLOAT)]
        public float Data3 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
        public float Data4 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
        public float Data5 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
        public float Data6 { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
        public float Data7 { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
        public float Data8 { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
        public float Data9 { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
        public float Data10 { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
        public float Data11 { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
        public float Data12 { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
        public float Data13 { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
        public float Data14 { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.FLOAT)]
        public float Data15 { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
        public float Data16 { get; set; }
    }
}
