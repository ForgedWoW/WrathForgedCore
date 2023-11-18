// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Chat;
using WrathForged.Common.Networking;
using WrathForged.Models.Chat;
using WrathForged.Models.Chat.Enums;
using WrathForged.Models.Realm.Enum;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ClientServices;

public class ChatService(IConfiguration configuration, ILogger logger, ChatNotifications chatNotifications) : IPacketService
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = logger;
    private readonly ChatNotifications _chatNotifications = chatNotifications;

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_MESSAGECHAT)]
    public void ChatMessage(RealmClientSession session, ChatMessage message)
    {
        if (message.Language == ChatLanguage.LANG_UNIVERSAL && message.MessageType != ChatMessageType.DND && message.MessageType != ChatMessageType.AFK)
        {
            _logger.Warning("Possible client cheat. Account {AccountId} tried to send a message in universal language from {IPAddress} with message: {Message}", session.Security.Account.Id, session.Network.ClientSocket.IPEndPoint.ToString(), message.Message);
            _chatNotifications.SendNotification(session, 805);
            return;
        }
    }
}
