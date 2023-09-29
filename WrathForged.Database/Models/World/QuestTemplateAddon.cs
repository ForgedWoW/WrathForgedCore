// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class QuestTemplateAddon
{
    public uint Id { get; set; }

    public byte MaxLevel { get; set; }

    public uint AllowableClasses { get; set; }

    public uint SourceSpellId { get; set; }

    public int PrevQuestId { get; set; }

    public uint NextQuestId { get; set; }

    public int ExclusiveGroup { get; set; }

    public int BreadcrumbForQuestId { get; set; }

    public uint RewardMailTemplateId { get; set; }

    public uint RewardMailDelay { get; set; }

    public ushort RequiredSkillId { get; set; }

    public ushort RequiredSkillPoints { get; set; }

    public ushort RequiredMinRepFaction { get; set; }

    public ushort RequiredMaxRepFaction { get; set; }

    public int RequiredMinRepValue { get; set; }

    public int RequiredMaxRepValue { get; set; }

    public byte ProvidedItemCount { get; set; }

    public byte SpecialFlags { get; set; }
}
