// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Chat.Enums;

namespace WrathForged.Models.Chat;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.CMSG_MESSAGECHAT)]
public class ChatMessage
{
    [SerializableProperty(0)]
    public ChatMessageType MessageType { get; set; }

    [SerializableProperty(1)]
    public ChatLanguage Language { get; set; }

    [SerializableProperty(2)]
    [ConditionalSerializers.SerializerConditionHasFlag<ChatMessageType>(0, ChatMessageType.WHISPER)]
    public string? To { get; set; }

    [SerializableProperty(3)]
    [ConditionalSerializers.SerializerConditionHasFlag<ChatMessageType>(0, ChatMessageType.CHANNEL)]
    public string? Channel { get; set; }

    [SerializableProperty(4)]
    public string Message { get; set; } = string.Empty;
}
