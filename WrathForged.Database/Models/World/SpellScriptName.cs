using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpellScriptName
{
    public int SpellId { get; set; }

    public string ScriptName { get; set; } = null!;
}
