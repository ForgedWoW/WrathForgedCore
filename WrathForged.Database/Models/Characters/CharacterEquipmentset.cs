// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterEquipmentset
{
    public uint Guid { get; set; }

    public ulong Setguid { get; set; }

    public byte Setindex { get; set; }

    public string Name { get; set; } = null!;

    public string Iconname { get; set; } = null!;

    public uint IgnoreMask { get; set; }

    public uint Item0 { get; set; }

    public uint Item1 { get; set; }

    public uint Item2 { get; set; }

    public uint Item3 { get; set; }

    public uint Item4 { get; set; }

    public uint Item5 { get; set; }

    public uint Item6 { get; set; }

    public uint Item7 { get; set; }

    public uint Item8 { get; set; }

    public uint Item9 { get; set; }

    public uint Item10 { get; set; }

    public uint Item11 { get; set; }

    public uint Item12 { get; set; }

    public uint Item13 { get; set; }

    public uint Item14 { get; set; }

    public uint Item15 { get; set; }

    public uint Item16 { get; set; }

    public uint Item17 { get; set; }

    public uint Item18 { get; set; }
}
