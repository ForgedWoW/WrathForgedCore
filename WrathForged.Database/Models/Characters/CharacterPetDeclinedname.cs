// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class CharacterPetDeclinedname
{
    public uint Id { get; set; }

    public uint Owner { get; set; }

    public string Genitive { get; set; } = null!;

    public string Dative { get; set; } = null!;

    public string Accusative { get; set; } = null!;

    public string Instrumental { get; set; } = null!;

    public string Prepositional { get; set; } = null!;
}
