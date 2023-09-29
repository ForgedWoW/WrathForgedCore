﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class GameEventSave
{
    public byte EventEntry { get; set; }

    public byte State { get; set; }

    public uint NextStart { get; set; }
}
