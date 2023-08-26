using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterGlyph
{
    public uint Guid { get; set; }

    public byte TalentGroup { get; set; }

    public ushort? Glyph1 { get; set; }

    public ushort? Glyph2 { get; set; }

    public ushort? Glyph3 { get; set; }

    public ushort? Glyph4 { get; set; }

    public ushort? Glyph5 { get; set; }

    public ushort? Glyph6 { get; set; }
}
