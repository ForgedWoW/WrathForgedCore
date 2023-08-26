using System;
using System.Collections.Generic;

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
