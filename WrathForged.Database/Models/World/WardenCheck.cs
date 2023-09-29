// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class WardenCheck
{
    public ushort Id { get; set; }

    public byte? Type { get; set; }

    public string? Str { get; set; }

    public uint? Address { get; set; }

    public byte? Length { get; set; }

    public string? Comment { get; set; }

    public byte[]? Data { get; set; }

    public byte[]? Result { get; set; }
}
