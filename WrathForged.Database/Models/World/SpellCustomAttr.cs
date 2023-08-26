using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// SpellInfo custom attributes
/// </summary>
public partial class SpellCustomAttr
{
    /// <summary>
    /// spell id
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// SpellCustomAttributes
    /// </summary>
    public uint Attributes { get; set; }
}
