// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class BattlegroundTemplate
{
    public uint Id { get; set; }

    public ushort MinPlayersPerTeam { get; set; }

    public ushort MaxPlayersPerTeam { get; set; }

    public byte MinLvl { get; set; }

    public byte MaxLvl { get; set; }

    public uint AllianceStartLoc { get; set; }

    public float AllianceStartO { get; set; }

    public uint HordeStartLoc { get; set; }

    public float HordeStartO { get; set; }

    public float StartMaxDist { get; set; }

    public byte Weight { get; set; }

    public string ScriptName { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
