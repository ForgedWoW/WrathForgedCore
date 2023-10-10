// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

public partial class Autobroadcast
{
    public int Realmid { get; set; }

    public byte Id { get; set; }

    public byte? Weight { get; set; }

    public string Text { get; set; } = null!;
}
