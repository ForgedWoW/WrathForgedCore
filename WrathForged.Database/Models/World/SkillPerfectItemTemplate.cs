using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Crafting Perfection System
/// </summary>
public partial class SkillPerfectItemTemplate
{
    /// <summary>
    /// SpellId of the item creation spell
    /// </summary>
    public uint SpellId { get; set; }

    /// <summary>
    /// Specialization spell id
    /// </summary>
    public uint RequiredSpecialization { get; set; }

    /// <summary>
    /// chance to create the perfect item instead
    /// </summary>
    public float PerfectCreateChance { get; set; }

    /// <summary>
    /// perfect item type to create instead
    /// </summary>
    public uint PerfectItemType { get; set; }
}
