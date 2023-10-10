// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class TrainerSpell
{
    public uint TrainerId { get; set; }

    public uint SpellId { get; set; }

    public uint MoneyCost { get; set; }

    public uint ReqSkillLine { get; set; }

    public uint ReqSkillRank { get; set; }

    public uint ReqAbility1 { get; set; }

    public uint ReqAbility2 { get; set; }

    public uint ReqAbility3 { get; set; }

    public byte ReqLevel { get; set; }

    public int? VerifiedBuild { get; set; }
}
