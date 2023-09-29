// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class GameEventConditionSave
{
    public byte EventEntry { get; set; }

    public uint ConditionId { get; set; }

    public float? Done { get; set; }
}
