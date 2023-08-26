using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Skill Specialization System
/// </summary>
public partial class SkillExtraItemTemplate
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
    /// chance to create add
    /// </summary>
    public float AdditionalCreateChance { get; set; }

    /// <summary>
    /// max num of adds
    /// </summary>
    public byte AdditionalMaxNum { get; set; }
}
