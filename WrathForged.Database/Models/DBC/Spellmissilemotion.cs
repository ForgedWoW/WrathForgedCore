using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellmissilemotion
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ScriptBody { get; set; }

    public int Flags { get; set; }

    public int MissileCount { get; set; }
}
