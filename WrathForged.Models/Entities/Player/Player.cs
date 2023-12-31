﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Entities.Player;

public class Player
{
    public static Player DEFAULT_PLAYER { get; } = new();

    public EntityId EntityId { get; private set; }
}
