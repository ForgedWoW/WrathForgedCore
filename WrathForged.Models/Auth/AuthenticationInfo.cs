// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Runtime.Serialization;

namespace WrathForged.Models.Auth
{
    /// <summary>
    /// Holds authentication information
    /// </summary>
    [DataContract]
    public class AuthenticationInfo
    {
        /// <summary>
        /// Session key used for the session
        /// </summary>
        [DataMember]
        public required byte[] SessionKey;

        /// <summary>
        /// Salt used for the session
        /// </summary>
        [DataMember]
        public required byte[] Salt;

        /// <summary>
        /// Verifier used for the session
        /// </summary>
        [DataMember]
        public required byte[] Verifier;

        /// <summary>
        /// System information of the client
        /// </summary>
        [DataMember]
        public required byte[] SystemInformation;
    }
}