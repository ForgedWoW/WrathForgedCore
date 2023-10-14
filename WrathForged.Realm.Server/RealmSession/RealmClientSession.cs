// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Models.Account;
using WrathForged.Models.Entities.Player;

namespace WrathForged.Realm.Server.RealmSession;

public class RealmClientSession : WoWClientSession
{
    public RealmClientSession(ClientSocket clientSocket, PacketBuffer packetBuffer, ClassFactory classFactory) :
            base(clientSocket, packetBuffer, classFactory) => AddonInfo = classFactory.Locate<RealmClientAddonInfo>(new { session = this });

    public RealmClientAddonInfo AddonInfo { get; }

    public Dictionary<uint, AccountData> AccountData { get; } = [];

    /// <summary>
    ///     Player object for this session. If the player is not logged in, this will be the <see cref="Player.DEFAULT_PLAYER"/>
    /// </summary>
    public Player Player { get; set; } = Player.DEFAULT_PLAYER;
}
