﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Trigger System
/// </summary>
public partial class AreatriggerTavern
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string? Name { get; set; }
}
