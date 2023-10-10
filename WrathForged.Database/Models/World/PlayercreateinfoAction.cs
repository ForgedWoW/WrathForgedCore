// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class PlayercreateinfoAction
{
    public byte Race { get; set; }

    public byte Class { get; set; }

    public ushort Button { get; set; }

    public uint Action { get; set; }

    public ushort Type { get; set; }
}
