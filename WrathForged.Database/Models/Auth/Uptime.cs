// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Uptime system
/// </summary>
public partial class Uptime
{
    public uint Realmid { get; set; }

    public uint Starttime { get; set; }

    public uint Uptime1 { get; set; }

    public ushort Maxplayers { get; set; }

    public string Revision { get; set; } = null!;
}
