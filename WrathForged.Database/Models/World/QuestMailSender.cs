using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestMailSender
{
    public uint QuestId { get; set; }

    public uint RewardMailSenderEntry { get; set; }
}
