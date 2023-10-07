// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace WrathForged.Common.Cryptography
{
    /// <summary>
	/// Provides SRP6 public component hashing service.
	/// Review: u on http://srp.stanford.edu/design.html
	/// Or this diagram: https://www.codeproject.com/articles/1082676/communication-using-secure-remote-password-protoco
	/// </summary>
	public class SRP
    {
        public SRP(string username, BigInteger salt, BigInteger verifier)
        {
            Username = username;
            Salt = salt;
            Verifier = verifier;

            PrivateServerEphemeral = GetRandomNumber(19) % Modulus;
        }

        public SRP(string username, string password, BigInteger? salt = null)
        {
            Username = username;

            if (salt != null)
                Salt = salt.Value;
            else
                Salt = GetRandomNumber(32) % Modulus;

            Verifier = GenerateVerifier(username, password);

            PrivateServerEphemeral = GetRandomNumber(19) % Modulus;
        }

        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        /// <summary>
        /// I
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// N                                                   Taken from TrinityCore, same Modulus.
        /// </summary>
        public BigInteger Modulus { get; } = new(new byte[]
            {
                0x89, 0x4B, 0x64, 0x5E, 0x89, 0xE1, 0x53, 0x5B, 0xBD, 0xAD, 0x5B, 0x8B, 0x29, 0x06, 0x50, 0x53,
                0x08, 0x01, 0xB1, 0x8E, 0xBF, 0xBF, 0x5E, 0x8F, 0xAB, 0x3C, 0x82, 0x87, 0x2A, 0x3E, 0x9B, 0xB7,
            }, true, true);

        /// <summary>
        /// g
        /// </summary>
        public BigInteger Generator { get; } = 7;

        /// <summary>
        /// k
        /// </summary>
        public BigInteger Multiplier { get; } = 3;

        /// <summary>
        /// x
        /// </summary>
        public BigInteger PrivateKey { get; private set; }

        /// <summary>
        /// v
        /// </summary>
        public BigInteger Verifier { get; private set; }

        /// <summary>
        /// b
        /// </summary>
        public BigInteger PrivateServerEphemeral { get; private set; }

        /// <summary>
        /// s
        /// </summary>
        public BigInteger Salt { get; private set; }

        /// <summary>
        /// A
        /// </summary>
        public BigInteger ClientEphemeral { get; set; }

        /// <summary>
        /// B
        /// </summary>
        public BigInteger ServerEphemeral
        {
            get { return (Multiplier * Verifier + BigInteger.ModPow(Generator, PrivateServerEphemeral, Modulus)) % Modulus; }
        }

        /// <summary>
        /// K_s
        /// </summary>
        public BigInteger SessionKey
        {
            get { return GenerateSessionKey(ClientEphemeral, ServerEphemeral, PrivateServerEphemeral, Modulus, Verifier); }
        }

        /// <summary>
        /// M_c
        /// </summary>
        public BigInteger ClientProof { get; set; }

        /// <summary>
        /// M_s
        /// </summary>
        public BigInteger ServerProof
        {
            get { return GenerateServerProof(ClientEphemeral, ClientProof, SessionKey); }
        }

        public BigInteger GenerateClientProof()
        {
            return GenerateClientProof(Username, Modulus, Generator, Salt, SessionKey, ClientEphemeral, ServerEphemeral);
        }

        #region Static members

        private BigInteger GenerateVerifier(string username, string password)
        {
            var privateKey = Hash(Salt.ToProperByteArray(), Hash(Encoding.ASCII.GetBytes($"{username}:{password}".ToUpper())).ToProperByteArray());
            return Generator.ModPow(privateKey, Modulus);
        }

        private static BigInteger GenerateScrambler(BigInteger A, BigInteger B)
        {
            return Hash(A.ToProperByteArray(), B.ToProperByteArray());
        }

        private static BigInteger GenerateClientProof(string identifier, BigInteger modulus, BigInteger generator, BigInteger salt, BigInteger sessionKey, BigInteger A, BigInteger B)
        {
            // M = H(H(N) xor H(g), H(I), s, A, B, K)
            var N_hash = SHA1.HashData(modulus.ToProperByteArray());
            var g_hash = SHA1.HashData(generator.ToProperByteArray());

            // H(N) XOR H(g)
            for (int i = 0, j = N_hash.Length; i < j; i++)
                N_hash[i] ^= g_hash[i];

            return Hash(N_hash, SHA1.HashData(Encoding.ASCII.GetBytes(identifier)), salt.ToProperByteArray(), A.ToProperByteArray(), B.ToProperByteArray(), sessionKey.ToProperByteArray());
        }

        private static BigInteger GenerateSessionKey(BigInteger clientEphemeral, BigInteger serverEphemeral, BigInteger privateServerEphemeral, BigInteger modulus, BigInteger verifier)
        {
            return Interleave(BigInteger.ModPow(clientEphemeral * BigInteger.ModPow(verifier, GenerateScrambler(clientEphemeral, serverEphemeral), modulus), privateServerEphemeral, modulus));
        }

        private static BigInteger GenerateServerProof(BigInteger A, BigInteger clientProof, BigInteger sessionKey)
        {
            return Hash(A.ToProperByteArray(), clientProof.ToProperByteArray(), sessionKey.ToProperByteArray());
        }

        // http://www.ietf.org/rfc/rfc2945.txt
        // Chapter 3.1
        private static BigInteger Interleave(BigInteger sessionKey)
        {
            var T = sessionKey.ToProperByteArray().SkipWhile(b => b == 0).ToArray(); // Remove all leading 0-bytes
            if ((T.Length & 0x1) == 0x1)
                T = T.Skip(1).ToArray(); // Needs to be an even length, skip 1 byte if not
            var G = SHA1.HashData(Enumerable.Range(0, T.Length).Where(i => (i & 0x1) == 0x0).Select(i => T[i]).ToArray());
            var H = SHA1.HashData(Enumerable.Range(0, T.Length).Where(i => (i & 0x1) == 0x1).Select(i => T[i]).ToArray());

            var result = new byte[40];
            for (int i = 0, r_c = 0; i < result.Length / 2; i++)
            {
                result[r_c++] = G[i];
                result[r_c++] = H[i];
            }


            return result.ToBigInteger();
        }

        private static BigInteger Hash(params byte[][] args)
        {
            return SHA1.HashData(args.SelectMany(b => b).ToArray()).ToBigInteger();
        }

        private static BigInteger GetRandomNumber(uint bytes)
        {
            var data = new byte[bytes];
            _rng.GetNonZeroBytes(data);
            return data.ToBigInteger();
        }

        #endregion
    }
}
