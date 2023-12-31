﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

public partial class IpLocation
{
    public string IpAddress { get; set; } = string.Empty;
    public string AddressInfo { get; set; } = string.Empty;
}
