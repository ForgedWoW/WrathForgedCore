// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class NpcSpellclickSpell
{
    /// <summary>
    /// reference to creature_template
    /// </summary>
    public uint NpcEntry { get; set; }

    /// <summary>
    /// spell which should be casted 
    /// </summary>
    public uint SpellId { get; set; }

    /// <summary>
    /// first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit
    /// </summary>
    public byte CastFlags { get; set; }

    /// <summary>
    /// relation with summoner: 0-no 1-friendly 2-raid 3-party player can click
    /// </summary>
    public ushort UserType { get; set; }
}
