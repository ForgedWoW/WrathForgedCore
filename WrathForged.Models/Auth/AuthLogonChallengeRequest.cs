// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Net;
using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Scope = PacketScope.Auth, PacketIDs = new[] { (uint)AuthServerOpCode.AUTH_LOGON_CHALLENGE })]
    public class AuthLogonChallengeRequest
    {
        /// <summary>
        /// Authentication protocol version to use.
        /// Trinitycore/Mangos has this marked as an error but Ember https://github.com/EmberEmu/Ember/blob/spark-new/src/login/grunt/client/LoginChallenge.h has this
        /// marked as the protocol field.
        /// </summary>
        [SerializableProperty(0)]
        public ProtocolVersion Protocol { get; set; }

        //We don't need to expose this really. Shouldn't need to be checked. This isn't C++
        /// <summary>
        /// Packet size. Computed by Trinitycore as the size of the payload + the username size.
        /// </summary>
        [SerializableProperty(1)]
        public ushort Size { get; set; }

        /// <summary>
        /// Game the client is for.
        /// </summary>
        ///
        [SerializableProperty(2, OverrideType = ForgedTypeCode.StringParsedEnum, FixedCollectionSize = 4)]
        public ClientType ClientType { get; set; }

        /// <summary>
        ///     Indicates the Major patch version (Ex. 3.x.x.x)
        /// </summary>
        [SerializableProperty(3)]
        public ExpansionType Major { get; set; }

        /// <summary>
        ///     Indicates the Minor patch version (Ex. x.3.x.x)
        /// </summary>
        [SerializableProperty(4)]
        public byte Minor { get; set; }

        /// <summary>
        ///     Indicates the Revision patch version (Ex. x.x.5.x)
        /// </summary>
        [SerializableProperty(5)]
        public byte Revision { get; set; }

        /// <summary>
        ///     Indicates the Build patch version (Ex. x.x.x.12340)
        /// </summary>
        [SerializableProperty(6)]
        public byte Build { get; set; }

        /// <summary>
        ///     Indicates the platform/arc (Ex. 32bit or 64bit)
        /// </summary>
        [SerializableProperty(7, OverrideType = ForgedTypeCode.StringParsedEnum, FixedCollectionSize = 4, ReversedString = true)]
        public ProcessorArchitecture Architecture { get; set; }

        /// <summary>
        ///     Indicates the operating system the client is running on (Ex. Win or Mac)
        /// </summary>
        [SerializableProperty(8, OverrideType = ForgedTypeCode.StringParsedEnum, FixedCollectionSize = 4, ReversedString = true)]
        public OperatingSystemType OperatingSystem { get; set; }

        /// <summary>
        ///     Indicates the Locale of the client. (Ex. En-US)
        /// </summary>
        [SerializableProperty(9, OverrideType = ForgedTypeCode.StringParsedEnum, FixedCollectionSize = 4, ReversedString = true)]
        public ClientLocale Locale { get; set; }

        [SerializableProperty(10)]
        public uint TimeZoneBias { get; set; }

        [SerializableProperty(11)]
        public IPAddress IpAddress { get; set; }

        /// <summary>
        /// Could be Username or maybe Email.
        /// </summary>
        public string Identity { get; set; }
    }
}