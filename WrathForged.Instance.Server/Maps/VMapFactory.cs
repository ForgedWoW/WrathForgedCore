// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using WrathForged.Common;

namespace WrathForged.Instance.Server.Maps;

public class VMapFactory(IConfiguration configuration, ClassFactory classFactory)
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ClassFactory _classFactory = classFactory;

    public bool LoadMap(uint mapId, int x, int y) => false;
}
