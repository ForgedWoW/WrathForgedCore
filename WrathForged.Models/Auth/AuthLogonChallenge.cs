// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public class AuthLogonChallenge
    {
        [SerializableProperty(0)]
        public byte Cmd { get; set; }

        [SerializableProperty(1)]
        public byte Error { get; set; }

        [SerializableProperty(2)]
        public ushort Size { get; set; }

        // Specifying the string as ASCII with a fixed size
        [SerializableProperty(3, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string GameName { get; set; }

        [SerializableProperty(4)]
        public byte Version1 { get; set; }

        [SerializableProperty(5)]
        public byte Version2 { get; set; }

        [SerializableProperty(6)]
        public byte Version3 { get; set; }

        [SerializableProperty(7)]
        public ushort Build { get; set; }

        // Specifying the strings as ASCII with a fixed size
        [SerializableProperty(8, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string Platform { get; set; }

        [SerializableProperty(9, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string OS { get; set; }

        [SerializableProperty(10, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string Country { get; set; }

        [SerializableProperty(11)]
        public uint TimezoneBias { get; set; }

        // Using the new IPAddress serialization
        [SerializableProperty(12)]
        public IPAddress IP { get; set; }

        // Assuming I is a variable-length byte array
        [SerializableProperty(13)]
        public byte[] I { get; set; }
    }
}