// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Chat;

namespace WrathForged.Common.Chat;

public class ChatNotifications
{
    public void SendNotification(IWoWClientSession session, string message)
    {
        session.Network.Send(new ChatNotification()
        {
            Message = message
        });
    }

    public void SendNotification(IWoWClientSession session, uint messageId, params object[] args)
    {
        var message = session.Localizer.Localize(messageId);

        if (string.IsNullOrEmpty(message))
            return;

        session.Network.Send(new ChatNotification()
        {
            Message = args.Length > 0 ? string.Format(message, args) : message
        });
    }
}
