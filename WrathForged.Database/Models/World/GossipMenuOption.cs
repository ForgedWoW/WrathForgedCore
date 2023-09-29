// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class GossipMenuOption
{
    public ushort MenuId { get; set; }

    public ushort OptionId { get; set; }

    public uint OptionIcon { get; set; }

    public string? OptionText { get; set; }

    public int OptionBroadcastTextId { get; set; }

    public byte OptionType { get; set; }

    public uint OptionNpcFlag { get; set; }

    public uint ActionMenuId { get; set; }

    public uint ActionPoiId { get; set; }

    public byte BoxCoded { get; set; }

    public uint BoxMoney { get; set; }

    public string? BoxText { get; set; }

    public int BoxBroadcastTextId { get; set; }

    public int VerifiedBuild { get; set; }
}
