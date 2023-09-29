// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class PvpstatsPlayer
{
    public ulong BattlegroundId { get; set; }

    public uint CharacterGuid { get; set; }

    public ulong Winner { get; set; }

    public uint ScoreKillingBlows { get; set; }

    public uint ScoreDeaths { get; set; }

    public uint ScoreHonorableKills { get; set; }

    public uint ScoreBonusHonor { get; set; }

    public uint ScoreDamageDone { get; set; }

    public uint ScoreHealingDone { get; set; }

    public uint Attr1 { get; set; }

    public uint Attr2 { get; set; }

    public uint Attr3 { get; set; }

    public uint Attr4 { get; set; }

    public uint Attr5 { get; set; }
}
