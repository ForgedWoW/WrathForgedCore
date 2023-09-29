// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class CreatureClasslevelstat
{
    public byte Level { get; set; }

    public byte Class { get; set; }

    public ushort Basehp0 { get; set; }

    public ushort Basehp1 { get; set; }

    public ushort Basehp2 { get; set; }

    public ushort Basemana { get; set; }

    public ushort Basearmor { get; set; }

    public ushort Attackpower { get; set; }

    public ushort Rangedattackpower { get; set; }

    public float DamageBase { get; set; }

    public float DamageExp1 { get; set; }

    public float DamageExp2 { get; set; }

    public string? Comment { get; set; }
}
