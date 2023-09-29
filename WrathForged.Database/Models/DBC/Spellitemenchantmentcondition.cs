// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spellitemenchantmentcondition
{
    public int Id { get; set; }

    public byte LtOperandType1 { get; set; }

    public byte LtOperandType2 { get; set; }

    public byte LtOperandType3 { get; set; }

    public byte LtOperandType4 { get; set; }

    public byte LtOperandType5 { get; set; }

    public int LtOperand1 { get; set; }

    public int LtOperand2 { get; set; }

    public int LtOperand3 { get; set; }

    public int LtOperand4 { get; set; }

    public int LtOperand5 { get; set; }

    public byte Operator1 { get; set; }

    public byte Operator2 { get; set; }

    public byte Operator3 { get; set; }

    public byte Operator4 { get; set; }

    public byte Operator5 { get; set; }

    public byte RtOperandType1 { get; set; }

    public byte RtOperandType2 { get; set; }

    public byte RtOperandType3 { get; set; }

    public byte RtOperandType4 { get; set; }

    public byte RtOperandType5 { get; set; }

    public int RtOperand1 { get; set; }

    public int RtOperand2 { get; set; }

    public int RtOperand3 { get; set; }

    public int RtOperand4 { get; set; }

    public int RtOperand5 { get; set; }

    public byte Logic1 { get; set; }

    public byte Logic2 { get; set; }

    public byte Logic3 { get; set; }

    public byte Logic4 { get; set; }

    public byte Logic5 { get; set; }

    public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
}
