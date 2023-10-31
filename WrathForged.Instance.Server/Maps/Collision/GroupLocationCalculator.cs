// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Instance.Server.Maps.Collision;
public class GroupLocationCalculator(GroupCollisionCalculator hitModel)
{
    public GroupCollisionCalculator HitModel { get; set; } = hitModel;
    public uint RootId { get; set; }
}
