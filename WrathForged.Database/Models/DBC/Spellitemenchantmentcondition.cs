// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellItemEnchantmentCondition.dbc")]
    public partial class Spellitemenchantmentcondition : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.BYTE)]
        public byte LtOperandType1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.BYTE)]
        public byte LtOperandType2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.BYTE)]
        public byte LtOperandType3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.BYTE)]
        public byte LtOperandType4 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.BYTE)]
        public byte LtOperandType5 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int LtOperand1 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int LtOperand2 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int LtOperand3 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int LtOperand4 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int LtOperand5 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.BYTE)]
        public byte Operator1 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.BYTE)]
        public byte Operator2 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.BYTE)]
        public byte Operator3 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.BYTE)]
        public byte Operator4 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.BYTE)]
        public byte Operator5 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.BYTE)]
        public byte RtOperandType1 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.BYTE)]
        public byte RtOperandType2 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.BYTE)]
        public byte RtOperandType3 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.BYTE)]
        public byte RtOperandType4 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.BYTE)]
        public byte RtOperandType5 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int RtOperand1 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
        public int RtOperand2 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.INT32)]
        public int RtOperand3 { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.INT32)]
        public int RtOperand4 { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.INT32)]
        public int RtOperand5 { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.BYTE)]
        public byte Logic1 { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.BYTE)]
        public byte Logic2 { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.BYTE)]
        public byte Logic3 { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.BYTE)]
        public byte Logic4 { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.BYTE)]
        public byte Logic5 { get; set; }

        public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
    }
}
