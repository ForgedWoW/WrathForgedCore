// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class GameobjectQuestitem
{
    public uint GameObjectEntry { get; set; }

    public uint Idx { get; set; }

    public uint ItemId { get; set; }

    public int? VerifiedBuild { get; set; }
}
