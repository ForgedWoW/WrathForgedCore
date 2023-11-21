// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.EntityFrameworkCore;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Characters;
using WrathForged.Models.Realm.Enum;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ForgedServices;

public class CharacterService(ClassFactory classFactory) : IPacketService
{
    private readonly ClassFactory _classFactory = classFactory;

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_CHAR_ENUM)]
    public void CharacterList(RealmClientSession session)
    {
        using var characterDatabase = _classFactory.Container.Locate<CharacterDatabase>();
        _ = characterDatabase.Database.ExecuteSqlRaw("CALL CHAR_DEL_EXPIRED_BANS");
    }
}
