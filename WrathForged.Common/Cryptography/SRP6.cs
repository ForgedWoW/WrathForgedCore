// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Globalization;
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
	public class SRP6
    {
        public SRP6(string username, BigInteger salt, BigInteger verifier)
        {
            Username = username;
            Salt = salt;
            Verifier = verifier;

            PrivateServerEphemeral = GetRandomNumber(19) % Modulus;
        }

        public SRP6(string username, string password)
        {
            Username = username;
            Salt = GetRandomNumber(32) % Modulus;
            Verifier = GenerateVerifier(username, password);

            PrivateServerEphemeral = GetRandomNumber(19) % Modulus;
        }

        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        // I
        public string Username { get; private set; }

        // N                                                   Taken from TrinityCore, same Modulus.
        public BigInteger Modulus { get; } = BigInteger.Parse("894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7", NumberStyles.HexNumber);

        // g
        public BigInteger Generator { get; } = 7;

        // k
        public BigInteger Multiplier { get; } = 3;

        // x
        public BigInteger PrivateKey { get; private set; }

        // v
        public BigInteger Verifier { get; private set; }

        // b
        public BigInteger PrivateServerEphemeral { get; private set; }

        // s
        public BigInteger Salt { get; private set; }

        // A
        public BigInteger ClientEphemeral { get; set; }

        // B
        public BigInteger ServerEphemeral
        {
            get { return (Multiplier * Verifier + BigInteger.ModPow(Generator, PrivateServerEphemeral, Modulus)) % Modulus; }
        }

        // K_s
        public BigInteger SessionKey
        {
            get { return GenerateSessionKey(ClientEphemeral, ServerEphemeral, PrivateServerEphemeral, Modulus, Verifier); }
        }

        // M_c
        public BigInteger ClientProof { get; set; }

        // M_s
        public BigInteger ServerProof
        {
            get { return GenerateServerProof(ClientEphemeral, ClientProof, SessionKey); }
        }

        public BigInteger GenerateClientProof()
        {
            return GenerateClientProof(Username, Modulus, Generator, Salt, SessionKey, ClientEphemeral, ServerEphemeral);
        }

        private BigInteger GenerateVerifier(string identifier, string password)
        {
            return GenerateVerifier(identifier, password, Modulus, Generator, Salt);
        }

        #region Static members

        private static BigInteger GenerateVerifier(string identifier, string password, BigInteger modulus, BigInteger generator, BigInteger salt)
        {
            var privateKey = Hash(salt.ToProperByteArray(), Hash(Encoding.ASCII.GetBytes(identifier + ":" + password)).ToProperByteArray());
            return BigInteger.ModPow(generator, privateKey, modulus);
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


            return result.ToPositiveBigInteger();
        }

        private static BigInteger Hash(params byte[][] args)
        {
            return SHA1.HashData(args.SelectMany(b => b).ToArray()).ToPositiveBigInteger();
        }

        private static BigInteger GetRandomNumber(uint bytes)
        {
            var data = new byte[bytes];
            _rng.GetNonZeroBytes(data);
            return data.ToPositiveBigInteger();
        }

        #endregion
    }
}
