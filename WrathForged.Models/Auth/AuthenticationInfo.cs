// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Models.Auth
{
    /// <summary>
    /// Holds authentication information
    /// </summary>
    public partial record AuthenticationInfo
    {
        /// <summary>
        /// Session key used for the session
        /// </summary>
        public required byte[] SessionKey { get; set; }

        /// <summary>
        /// Salt used for the session
        /// </summary>
        public required byte[] Salt { get; set; }

        /// <summary>
        /// Verifier used for the session
        /// </summary>
        public required byte[] Verifier { get; set; }

        /// <summary>
        /// System information of the client
        /// </summary>
        public required byte[] SystemInformation { get; set; }
    }
}