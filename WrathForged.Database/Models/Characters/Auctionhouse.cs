// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

public partial class Auctionhouse
{
    public uint Id { get; set; }

    public byte Houseid { get; set; }

    public uint Itemguid { get; set; }

    public uint Itemowner { get; set; }

    public uint Buyoutprice { get; set; }

    public uint Time { get; set; }

    public uint Buyguid { get; set; }

    public uint Lastbid { get; set; }

    public uint Startbid { get; set; }

    public uint Deposit { get; set; }

    public byte Flags { get; set; }
}
