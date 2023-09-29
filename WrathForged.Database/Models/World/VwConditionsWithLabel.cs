// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class VwConditionsWithLabel
{
    public string SourceTypeOrReferenceId { get; set; } = null!;

    public uint SourceGroup { get; set; }

    public int SourceEntry { get; set; }

    public int SourceId { get; set; }

    public uint ElseGroup { get; set; }

    public string ConditionTypeOrReference { get; set; } = null!;

    public byte ConditionTarget { get; set; }

    public uint ConditionValue1 { get; set; }

    public uint ConditionValue2 { get; set; }

    public uint ConditionValue3 { get; set; }

    public byte NegativeCondition { get; set; }

    public uint ErrorType { get; set; }

    public uint ErrorTextId { get; set; }

    public string ScriptName { get; set; } = null!;

    public string? Comment { get; set; }
}
