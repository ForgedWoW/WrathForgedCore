// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth;

namespace WrathForged.Realm.Server.RealmSession
{
    public class RealmClientAddonInfo(RealmClientSession session)
    {

        public ClientAddons ClientAddons { get; set; }
    }
}
