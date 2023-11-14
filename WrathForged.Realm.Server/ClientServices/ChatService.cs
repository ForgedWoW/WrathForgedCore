// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Models.Chat;
using WrathForged.Models.Realm.Enum;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ClientServices;

public class ChatService(IConfiguration configuration, ILogger logger) : IPacketService
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = logger;

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_MESSAGECHAT)]
    public void ChatMessage(RealmClientSession session, ChatMessage message)
    {

    }
}
