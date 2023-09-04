// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;

namespace WrathForged.Authorization.Server.Validators
{
    public class BanValidator
    {
        private readonly ForgeCache _forgeCache;

        public BanValidator(ForgeCache forgeCache) => _forgeCache = forgeCache;
    }
}