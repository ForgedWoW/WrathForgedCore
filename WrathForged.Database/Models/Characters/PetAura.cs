﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Pet System
/// </summary>
public partial class PetAura
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Full Global Unique Identifier
    /// </summary>
    public ulong CasterGuid { get; set; }

    public uint Spell { get; set; }

    public byte EffectMask { get; set; }

    public byte RecalculateMask { get; set; }

    public byte StackCount { get; set; }

    public int Amount0 { get; set; }

    public int Amount1 { get; set; }

    public int Amount2 { get; set; }

    public int BaseAmount0 { get; set; }

    public int BaseAmount1 { get; set; }

    public int BaseAmount2 { get; set; }

    public int MaxDuration { get; set; }

    public int RemainTime { get; set; }

    public byte RemainCharges { get; set; }

    public float CritChance { get; set; }

    public sbyte ApplyResilience { get; set; }
}
