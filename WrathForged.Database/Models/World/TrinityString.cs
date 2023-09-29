// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.ComponentModel.DataAnnotations.Schema;

namespace WrathForged.Database.Models.World;

public partial class TrinityString
{
    public uint Entry { get; set; }

    public string? Content0 { get => Content[0]; set => Content[0] = value; }
    public string? Content1 { get => Content[1]; set => Content[1] = value; }
    public string? Content2 { get => Content[2]; set => Content[2] = value; }
    public string? Content3 { get => Content[3]; set => Content[3] = value; }
    public string? Content4 { get => Content[4]; set => Content[4] = value; }
    public string? Content5 { get => Content[5]; set => Content[5] = value; }
    public string? Content6 { get => Content[6]; set => Content[6] = value; }
    public string? Content7 { get => Content[7]; set => Content[7] = value; }
    public string? Content8 { get => Content[8]; set => Content[8] = value; }

    [NotMapped]
    public string?[] Content { get; } = new string[9];
}