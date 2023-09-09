// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace WrathForged.Common.Cryptography
{
    /// <summary>
    /// Provides facilities for performing common-but-specific
    /// cryptographical operations
    /// </summary>
    public static class HashUtilities
    {
        /// <summary>
        /// Brokers various data types into their integral raw
        /// form for usage by other cryptographical functions
        /// </summary>
        public class HashDataBroker
        {
            /// <summary>
            /// Default constructor
            /// </summary>
            /// <param name="data">the data to broker</param>
            public HashDataBroker(byte[] data) => RawData = data;

            internal byte[] RawData;

            internal int Length => RawData.Length;

            /// <summary>
            /// Implicit operator for byte[]->HashDataBroker casts
            /// </summary>
            /// <param name="data">the data to broker</param>
            /// <returns>a HashDataBroker object representing the original data</returns>
            public static implicit operator HashDataBroker(byte[] data) => new(data);

            /// <summary>
            /// Implicit operator for string->HashDataBroker casts
            /// </summary>
            /// <param name="str">the data to broker</param>
            /// <returns>a HashDataBroker object representing the original data</returns>
            public static implicit operator HashDataBroker(string str) => new(Encoding.UTF8.GetBytes(str));

            /// <summary>
            /// Implicit operator for BigInteger->HashDataBroker casts
            /// </summary>
            /// <param name="integer">the data to broker</param>
            /// <returns>a HashDataBroker object representing the original data</returns>
            public static implicit operator HashDataBroker(BigInteger integer) => new(integer.ToByteArray());

            /// <summary>
            /// Implicit operator for uint->HashDataBroker casts
            /// </summary>
            /// <param name="integer">the data to broker</param>
            /// <returns>a HashDataBroker object representing the original data</returns>
            public static implicit operator HashDataBroker(uint integer) => new(new BigInteger(integer).ToByteArray());
        }

        /// <summary>
        /// Computes a hash from hash data brokers using the given
        /// hashing algorithm
        /// </summary>
        /// <param name="algorithm">the hashing algorithm to use</param>
        /// <param name="brokers">the data brokers to hash</param>
        /// <returns>the hash result of all the data brokers</returns>
        public static byte[] FinalizeHash(HashAlgorithm algorithm, params HashDataBroker[] brokers)
        {
            var buffer = new MemoryStream();

            foreach (var broker in brokers)
            {
                buffer.Write(broker.RawData, 0, broker.Length);
            }

            buffer.Position = 0;

            return algorithm.ComputeHash(buffer);
        }

        /// <summary>
        /// Computes a hash from hash data brokers using the given
        /// hash algorithm, and generates a BigInteger from it
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="brokers"></param>
        /// <returns></returns>
        public static BigInteger HashToBigInteger(HashAlgorithm algorithm, params HashDataBroker[] brokers) => new(FinalizeHash(algorithm, brokers));
    }
}