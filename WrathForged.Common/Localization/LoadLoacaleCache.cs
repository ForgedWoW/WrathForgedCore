// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Scripting.Interfaces.CoreEvents;
using WrathForged.Database.Models.World;

namespace WrathForged.Common.Localization
{
    public class LoadLoacaleCache : IOnServerInitialize
    {
        private readonly ForgeCache _forgeCache;
        private readonly WorldDatabase _worldDatabase;

        public LoadLoacaleCache(ForgeCache forgeCache, WorldDatabase worldDatabase)
        {
            _forgeCache = forgeCache;
            _worldDatabase = worldDatabase;
        }

        public void OnServerInitialize() => _forgeCache.Set(LocaleConst.CACHE_KEY, TimeSpan.FromMinutes(20), () => _worldDatabase.TrinityStrings.ToDictionary(d => d.Entry, d => d.Content));
    }
}