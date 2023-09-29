// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class QuestTracker
{
    public uint Id { get; set; }

    public uint CharacterGuid { get; set; }

    public DateTime QuestAcceptTime { get; set; }

    public DateTime? QuestCompleteTime { get; set; }

    public DateTime? QuestAbandonTime { get; set; }

    public bool CompletedByGm { get; set; }

    public string CoreHash { get; set; } = null!;

    public string CoreRevision { get; set; } = null!;
}
