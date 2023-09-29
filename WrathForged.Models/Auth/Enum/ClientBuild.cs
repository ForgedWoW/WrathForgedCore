// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    /// <summary>
	/// Enumeration of known client build IDs.
	/// </summary>
	public enum ClientBuild : ushort //Must be ushort. uint16 build;
    {
        //Vanilla
        Vanilla_1_12_1 = 5875,

        Vanilla_1_12_2 = 6005,
        Vanilla_1_12_3 = 6141,

        //Only build number Mangos has
        TBC_2_4_3 = 8606,

        //Wotlk
        Wotlk_3_2_2a = 10505,

        Wotlk_3_3_0a = 11159,
        Wotlk_3_3_2 = 11403,
        Wotlk_3_3_3a = 11723,
        Wotlk_3_3_5a = 12340,

        //TODO: add the rest I guess.
    }
}