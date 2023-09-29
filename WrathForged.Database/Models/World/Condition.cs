// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Condition System
/// </summary>
public partial class Condition
{
    public int SourceTypeOrReferenceId { get; set; }

    public uint SourceGroup { get; set; }

    public int SourceEntry { get; set; }

    public int SourceId { get; set; }

    public uint ElseGroup { get; set; }

    public int ConditionTypeOrReference { get; set; }

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
