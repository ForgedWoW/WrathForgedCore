// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Transports
/// </summary>
public partial class Transport
{
    public uint Guid { get; set; }

    public uint Entry { get; set; }

    public string? Name { get; set; }

    public string ScriptName { get; set; } = null!;
}
