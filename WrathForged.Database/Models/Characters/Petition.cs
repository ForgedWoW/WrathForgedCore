// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class Petition
{
    public uint Ownerguid { get; set; }

    public uint? Petitionguid { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }
}
