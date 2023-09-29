// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Weaponswingsounds2
{
    public int Id { get; set; }

    public int SwingType { get; set; }

    public int Crit { get; set; }

    public int? SoundId { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
