// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace WrathForged.Common.Cryptography
{
    public partial class SecureRemotePassword
    {
        /// <summary>
        /// The required minimum length of a password
        /// </summary>
        public const int MIN_PASS_LENGTH = 3;

        /// <summary>
        /// The required maximum length of a password
        /// </summary>
        public const int MAX_PASS_LENGTH = 16;

        private readonly bool _isServer;
        private SRPParameters _srpParams = SRPParameters.Defaults;
        private BigInteger _credentialsHash;
        private BigInteger _salt;
        private BigInteger _sessionKey;
        private BigInteger _publicEphemeralValueA;
        private readonly BigInteger _secretEphemeralValueA = RandomNumber();
        private BigInteger _publicEphemeralValueB;
        private BigInteger _secretEphemeralValueB;
        private BigInteger _verifier;

        public SecureRemotePassword(bool isServer, SRPParameters parameters)
        {
            _srpParams = parameters;
            _isServer = isServer;
            Username = string.Empty;
        }

        public SecureRemotePassword(bool isServer)
            : this(isServer, SRPParameters.Defaults)
        {
        }

        public SecureRemotePassword(string username, BigInteger credentials, bool isServer, SRPParameters parameters)
        {
            if (parameters.CaseSensitive == false)
            {
                username = username.ToUpper();
            }

            _srpParams = parameters;

            _isServer = isServer;
            Username = username;
            Credentials = credentials;
        }

        public SecureRemotePassword(string username, BigInteger credentials, bool isServer)
            : this(username, credentials, isServer, SRPParameters.Defaults)
        {
        }

        /// <summary>
        /// Make an SRP for user authentication. You use something like this when your
        /// verifier and salt are stored in a database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="verifier"></param>
        /// <param name="salt"></param>
        /// <param name="parameters"></param>
        public SecureRemotePassword(string username, BigInteger verifier, BigInteger salt, SRPParameters? parameters = null)
        {
            parameters ??= SRPParameters.Defaults;

            if (parameters.CaseSensitive == false)
            {
                username = username.ToUpper();
            }

            _srpParams = parameters;

            _isServer = true;
            Username = username;
            Verifier = verifier;
            _salt = salt;
        }

        public SecureRemotePassword(string username, BigInteger verifier, BigInteger salt)
            : this(username, verifier, salt, SRPParameters.Defaults)
        {
        }

        public SRPParameters Parameters
        {
            get { return _srpParams; }
            set { _srpParams = value; }
        }

        /// <summary>
        /// Are we the server? This should be set before calculation commences.
        /// </summary>
        public bool IsServer
        {
            get { return _isServer; }
        }

        /// <summary>
        /// Correct username. This should be set before calculations happen.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Referred to as 'M' in the documentation. This is used for authentication.
        /// 
        /// The client sends this value to the server and the server calculates it locally to verify it.
        /// The same then happens with ServerSessionKeyProof. Note ClientSessionKeyProof should come first.
        /// </summary>
        public BigInteger ClientSessionKeyProof
        {
            get
            {
                return
                    Hash((Hash(Modulus).ToBigInteger() ^ Hash(Generator).ToBigInteger()).ToProperByteArray(), SHA1.HashData(Encoding.ASCII.GetBytes(Username)), Salt.ToProperByteArray(), PublicEphemeralValueA.ToProperByteArray(),
                         PublicEphemeralValueB.ToProperByteArray(), SessionKey.ToProperByteArray());
            }
        }

        /// <summary>
        /// The server sends this to the client as proof it has the same session key as the client.
        /// The client will calculate this locally to verify.
        /// </summary>
        public BigInteger ServerSessionKeyProof
        {
            get { return Hash(PublicEphemeralValueA, ClientSessionKeyProof, SessionKey).ToBigInteger(); }
        }

        /// <summary>
        /// Generate a random number of maximal size
        /// </summary>
        /// <returns></returns>
        public static BigInteger RandomNumber()
        {
            return RandomNumber(SRPParameters.KEY_LENGTH);
        }

        public BigInteger Modulus
        {
            get { return Parameters.Modulus; }
        }

        public BigInteger Generator
        {
            get { return Parameters.Generator; }
        }

        /// <summary>
        /// 'k' in the spec. In SRP-6a k = H(N, g). Older versions have k = 3.
        /// </summary>
        public BigInteger Multiplier
        {
            get
            {
                if (Parameters.AlgorithmVersion == SRPParameters.SRPVersion.SRP6)
                    return (BigInteger)3;

                return Hash(Modulus, Generator).ToBigInteger();
            }
        }

        public BigInteger Credentials { get; set; }

        /// <summary>
        /// Salt for credentials hash. You can bind this to the users'
        /// account or use the automatically generated random salt.
        /// </summary>
        public BigInteger Salt
        {
            set { _salt = value; }
            get
            {
                if (_salt == default)
                {
                    if (IsServer == false)
                    {
                        throw new Exception("Unknown salt! This should be set by the server.");
                    }

                    _salt = RandomNumber();
                }

                return _salt;
            }
        }

        /// <summary>
        /// 'x' in the spec. Note that this is slightly different - the spec says
        /// x = H(s, p) whereas here x = H(s, H(I, p)), which is the implementation in the demo.
        /// </summary>
        public BigInteger CredentialsHash
        {
            get
            {
                if (_credentialsHash == default)
                {
                    _credentialsHash = Hash(Salt, Credentials).ToBigInteger();
                }

                return _credentialsHash;
            }
        }

        /// <summary>
        /// 'A' in the spec. A = g^a, generated by client and sent to the server
        /// </summary>
        public BigInteger PublicEphemeralValueA
        {
            get
            {
                // This guy is generated by the client and sent to the server
                if (IsServer == false && _publicEphemeralValueA == default)
                {
                    _publicEphemeralValueA = Generator.ModPow(_secretEphemeralValueA, Modulus);
                }

                return _publicEphemeralValueA;
            }
            set
            {
                if (IsServer == false)
                {
                    throw new Exception("Attempt by SRP client to set A. This is generated.");
                }

                _publicEphemeralValueA = value;

                _publicEphemeralValueA %= Modulus;

                if (_publicEphemeralValueA < 0)
                {
                    _publicEphemeralValueA += Modulus;
                }

                if (_publicEphemeralValueA == 0)
                {
                    // Abort - we got hackers.
                    throw new InvalidDataException("A cannot be 0 mod N!");
                }
            }
        }

        /// <summary>
        /// 'B' in the spec. B = kv + g^b, generated by the server and sent to the client
        /// </summary>
        public BigInteger PublicEphemeralValueB
        {
            get
            {
                // This guy is generated by the server and sent to the client
                if (IsServer && _publicEphemeralValueB == default)
                {
                    _secretEphemeralValueB = RandomNumber();
                    _publicEphemeralValueB = Multiplier * Verifier + Generator.ModPow(_secretEphemeralValueB, Modulus);
                    _publicEphemeralValueB %= Modulus;

                    if (_publicEphemeralValueB < 0)
                    {
                        _publicEphemeralValueB += Modulus;
                    }
                }

                return _publicEphemeralValueB;
            }
            set
            {
                if (IsServer)
                {
                    throw new Exception("Attempt by SRP server to set B. This is generated.");
                }

                _publicEphemeralValueB = value;
                _publicEphemeralValueB %= Modulus;
                if (_publicEphemeralValueB < 0)
                    _publicEphemeralValueB += Modulus;

                if (_publicEphemeralValueB == 0)
                {
                    // Abort - we got hackers.
                    throw new InvalidDataException("B cannot be 0 mod N!");
                }
            }
        }

        /// <summary>
        /// u in the spec. Generated by both server and client.
        /// </summary>
        public BigInteger ScramblingParameter
        {
            get { return Hash(PublicEphemeralValueA, PublicEphemeralValueB).ToBigInteger(); }
        }

        /// <summary>
        /// This is the session key used for encryption later.
        /// 'K' in the spec. Note that this is different to 'k' (Multiplier)
        /// </summary>
        public BigInteger SessionKeyRaw
        {
            get
            {
                if (_sessionKey == default)
                {
                    BigInteger S;
                    if (IsServer)
                    {
                        if (_publicEphemeralValueA == default)
                            return default;

                        // S = (Av^u) ^ b (mod N)
                        S = Verifier.ModPow(ScramblingParameter, Modulus);
                        S = (S * PublicEphemeralValueA) % Modulus;
                        S = S.ModPow(_secretEphemeralValueB, Modulus);
                    }
                    else
                    {
                        // S = (B - kg^x) ^ (a + ux) (mod N)
                        S = PublicEphemeralValueB - (Multiplier * Generator.ModPow(CredentialsHash, Modulus));
                        S = S.ModPow(_secretEphemeralValueA + ScramblingParameter * CredentialsHash, Modulus);

                        // If S flips negative above the mod function preserves its sign.
                        // We want it positive.
                        if (S < 0)
                            S += Modulus;
                    }

                    _sessionKey = S;
                }

                return _sessionKey;
            }
        }

        /// <summary>
        /// V in the spec.
        /// v = g^x (mod N)
        /// 
        /// This only makes sense for servers.
        /// </summary>
        public BigInteger Verifier
        {
            get
            {
                if (_verifier == default)
                {
                    _verifier = Generator.ModPow(CredentialsHash, Modulus);
                }

                if (_verifier < 0)
                {
                    _verifier += Modulus;
                }

                return _verifier;
            }
            set { _verifier = value; }
        }

        public BigInteger SessionKey
        {
            get
            {
                byte[] data = SessionKeyRaw.GetBytes(32);

                // This is a strange beast.
                var temp = new byte[16];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = data[2 * i];
                }

                byte[] hash1 = Hash(temp).GetBytes(20);

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = data[2 * i + 1];
                }

                byte[] hash2 = Hash(temp).GetBytes(20);

                // its an interleaving of the two hashes..
                data = new byte[40];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = i % 2 == 0 ? hash1[i / 2] : hash2[i / 2];
                }

                return new BigInteger(data);
            }
        }

        public byte[] Hash(params BigInteger[] brokers)
        {
            var concat = brokers[0].ToProperByteArray();

            for (int i = 1; i < brokers.Length; i++)
                concat.Concat(brokers[i].ToProperByteArray());

            return SHA1.HashData(concat.ToArray());
        }

        public BigInteger Hash(params byte[][] args)
        {
            return SHA1.HashData(args.SelectMany(b => b).ToArray()).ToBigInteger();
        }

        /// <summary>
        /// Generate a random number of a specified size
        /// </summary>
        /// <param name="size">Maximum size in bytes of the random number</param>
        /// <returns></returns>
        public static BigInteger RandomNumber(uint size)
        {
            var buffer = new byte[size];

            SRPParameters.RandomGenerator.GetBytes(buffer);

            // Must make sure the most significant byte is not zero
            if (buffer[0] == 0)
                buffer[0] = 1;

            return new BigInteger(buffer);
        }

        public bool IsClientProofValid(BigInteger client_proof)
        {
            return ClientSessionKeyProof == client_proof;
        }

        public bool IsServerProofValid(BigInteger server_proof)
        {
            return server_proof == ServerSessionKeyProof;
        }

        #region Nested type: SRPParameters

        [Serializable]
        public class SRPParameters
        {
            #region SRPVersion enum

            /// <summary>
            /// Algorithm version. Consult specification for differences.
            /// </summary>
            public enum SRPVersion
            {
                SRP6,
                SRP6a,
            }

            #endregion

            /// <summary>
            /// Maximum length of crypto keys in bytes.
            /// </summary>
            /// <remarks>You might get unlucky and have much shorter keys - this should be checked and keys recalculated.</remarks>
            public const uint KEY_LENGTH = 32;

            /// <summary>
            /// Random number generator for this instance.
            /// </summary>
            public static RandomNumberGenerator RandomGenerator { get; set; } = RandomNumberGenerator.Create();

            /// <summary>
            /// Version of this instance.
            /// </summary>
            public SRPVersion AlgorithmVersion { get; set; } = SRPVersion.SRP6;

            public bool CaseSensitive { get; set; } = false;

            /// <summary>
            /// Hashing function for the instance.
            /// </summary>
            /// <remarks>MD5 or other SHA hashes are usable, though SHA1 is more standard for SRP.</remarks>
            public static SHA1 Hash { get; } = SHA1.Create();

            /// <summary>
            /// 'g' in the spec. This number must be a generator in the finite field Modulus.
            /// </summary>
            private static readonly BigInteger _generator = new BigInteger(7);

            private static readonly BigInteger _modulus = new(new byte[]
            {
                0x89, 0x4B, 0x64, 0x5E, 0x89, 0xE1, 0x53, 0x5B, 0xBD, 0xAD, 0x5B, 0x8B, 0x29, 0x06, 0x50, 0x53,
                0x08, 0x01, 0xB1, 0x8E, 0xBF, 0xBF, 0x5E, 0x8F, 0xAB, 0x3C, 0x82, 0x87, 0x2A, 0x3E, 0x9B, 0xB7,
            }, true, true);

            /// <summary>
            /// All operations are mod this number. It should be a large prime.
            /// </summary>
            /// <remarks>Referred to as 'N' in the spec.</remarks>
            /// <remarks>Defaults to 128 bits.</remarks>
            public BigInteger Modulus
            {
                get { return _modulus; }
            }

            public BigInteger Generator
            {
                get { return _generator; }
            }

            public static SRPParameters Defaults
            {
                get { return new SRPParameters(); }
            }
        }

        #endregion


        /// <summary>
        /// Generates a hash for an account's credentials (username:password) based on the SRP hashing method,
        /// </summary>
        /// <param name="username">the username</param>
        /// <param name="password">the password</param>
        /// <returns>a byte array of the resulting hash</returns>
        public static byte[] GenerateCredentialsHash(string username, string password)
        {
            // Account-names are always upper case
            var buf = SRPParameters.Hash.ComputeHash(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", username.ToUpper(), password.ToUpper())));

            if (buf.Length > 20)
            {
                // should never happen, since we're using SHA1, which always outputs a 20byte hash
                throw new CryptographicException("SHA-1 hash too long - " + buf.Length + " bytes, should be 20!");
            }
            return buf;
        }
    }
}
