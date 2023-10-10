// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class SpellArea
{
    public uint Spell { get; set; }

    public uint Area { get; set; }

    public uint QuestStart { get; set; }

    public uint QuestEnd { get; set; }

    public int AuraSpell { get; set; }

    public uint Racemask { get; set; }

    public byte Gender { get; set; }

    public byte Autocast { get; set; }

    public int QuestStartStatus { get; set; }

    public int QuestEndStatus { get; set; }
}
