// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth.Enum
{
    /// <summary>
	/// Enumeration of all Expansions for WoW
	/// </summary>
	public enum ExpansionType : byte //uint8 version1;
    {
        /// <summary>
        /// No Expansion
        /// </summary>
        None = 0,

        /// <summary>
        /// 1.x.x (It is helpful to consider Vanilla an expansion upon the base engine)
        /// </summary>
        Vanilla = 1,

        /// <summary>
        /// 2.x.x
        /// </summary>
        TheBurningCrusade = 2,

        /// <summary>
        /// 3.x.x
        /// </summary>
        WrathOfTheLichKing = 3,

        /// <summary>
        /// 4.x.x
        /// </summary>
        Cataclysm = 4,

        /// <summary>
        /// 5.x.x
        /// </summary>
        MistsOfPandaria = 5,

        /// <summary>
        /// 6.x.x
        /// </summary>
        WarlordsOfDraenor = 6,

        /// <summary>
        /// 7.x.x
        /// </summary>
        Legion = 7
    }
}