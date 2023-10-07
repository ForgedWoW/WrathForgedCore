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
	public class PasswordHasher
    {
        public static BigInteger G { get; } = 7;

        /// <summary>
        /// The salt, a "random" value.
        /// </summary>
        public readonly byte[] S;

        /// <summary>
        /// The server's secret value.
        /// </summary>
        private readonly BigInteger _b;


        public PasswordHasher(string username, string password)
        {
            N = new(new byte[]
            {
                0x89, 0x4B, 0x64, 0x5E, 0x89, 0xE1, 0x53, 0x5B, 0xBD, 0xAD, 0x5B, 0x8B, 0x29, 0x06, 0x50, 0x53,
                0x08, 0x01, 0xB1, 0x8E, 0xBF, 0xBF, 0x5E, 0x8F, 0xAB, 0x3C, 0x82, 0x87, 0x2A, 0x3E, 0x9B, 0xB7,
            }, true, true);
            RN = N.ToProperByteArray().Reverse().ToArray().ToBigInteger();
            I = username;
            _b = GetRandom(19);
            S = GetRandom(32).ToProperByteArray();

            // The combined hash of salt + Identifier:Password.
            // SHA1(s | SHA1(I | ":" | P))
            var x = GetHashedCredentials(password);

            V = BigInteger.ModPow(G, x, N);

            var gmod = BigInteger.ModPow(G, _b, N);
            var tempB = (3 * V + gmod) % N;

            B = tempB.ToProperByteArray();
        }

        public PasswordHasher(string username, byte[] salt, byte[] verifier)
        {
            N = new(new byte[]
            {
                0x89, 0x4B, 0x64, 0x5E, 0x89, 0xE1, 0x53, 0x5B, 0xBD, 0xAD, 0x5B, 0x8B, 0x29, 0x06, 0x50, 0x53,
                0x08, 0x01, 0xB1, 0x8E, 0xBF, 0xBF, 0x5E, 0x8F, 0xAB, 0x3C, 0x82, 0x87, 0x2A, 0x3E, 0x9B, 0xB7,
            }, true, true);
            RN = N.ToProperByteArray().Reverse().ToArray().ToBigInteger();
            I = username;
            _b = GetRandom(19);
            S = salt;

            V = verifier.ToBigInteger();

            var gmod = BigInteger.ModPow(G, _b, N);
            var tempB = (3 * V + gmod) % N;

            B = tempB.ToProperByteArray();
        }


        /// <summary>
        /// The SRP6 Verification value.
        /// </summary>
        public BigInteger V { get; private set; }

        /// <summary>
        /// Gets the client's public value.
        /// </summary>
        public byte[] A { get; private set; } = [];

        /// <summary>
        /// Gets the server's public value.
        /// </summary>
        public byte[] B { get; } = [];

        public byte[] SessionKey { get; private set; } = [];

        /// <summary>
        /// The hashed session key, hashed with SHA1.
        /// </summary>
        public byte[] K { get; private set; } = [];

        /// <summary>
        /// M = H(H(N) xor H(g), H(I), s, A, B, K)
        /// </summary>
        public byte[] M { get; private set; } = [];

        /// <summary>
        /// Gets a safe-prime.
        /// </summary>
        public BigInteger N { get; }

        public BigInteger RN { get; }

        /// <summary>
        /// Gets the identifier (username).
        /// </summary>
        public string I { get; }

        public bool ValidateClientProof(byte[] clientPublicValue, byte[] clientProof)
        {
            A = clientPublicValue;

            // u = H(A, B)
            // u is the so called "Random scrambling parameter".
            var u = SHA1.HashData(A.Concat(B).ToArray()).ToBigInteger();

            var sessionKeyAsByte = CalculateSessionKey(u).ToProperByteArray();
            K = SHA1.HashData(sessionKeyAsByte);

            var vK = new int[40];
            var t1 = new List<byte>();

            for (int i = 0; i < 16; i++)
                t1.Add(sessionKeyAsByte[i * 2]);

            byte[] t1_hash = SHA1.HashData(t1.ToArray());

            for (int i = 0; i < 20; i++)
                vK[i * 2] = t1_hash[i];

            for (int i = 0; i < 16; i++)
                t1[i] = sessionKeyAsByte[i * 2 + 1];

            t1_hash = SHA1.HashData(t1.ToArray());

            for (int i = 0; i < 20; i++)
                vK[i * 2 + 1] = t1_hash[i];

            SessionKey = Array.ConvertAll(vK, Convert.ToByte);

            var safePrimeHash = SHA1.HashData(N.ToByteArray().Take(32).ToArray());
            var gHash = SHA1.HashData(G.ToByteArray());

            var t3 = new List<int>();
            for (int i = 0; i < 20; i++)
                t3.Add(safePrimeHash[i] ^ gHash[i]);

            var t4 = SHA1.HashData(Encoding.ASCII.GetBytes(I));

            var t3Bytes = Array.ConvertAll(t3.ToArray(), Convert.ToByte);
            var computedClientProof =
                SHA1.HashData(
                    // t3 + t4 + salt + A + B + sessionKey
                    t3Bytes.Concat(t4).Concat(S).Concat(A).Concat(B).Concat(SessionKey).ToArray());

            if (!computedClientProof.SequenceEqual(clientProof))
                return false;

            M = SHA1.HashData(A.Concat(clientProof).Concat(SessionKey).ToArray());
            return true;
        }

        private BigInteger CalculateSessionKey(BigInteger u)
        {
            // S = (A * (v^u) % N) ^ b % N
            var intA = new BigInteger(A);

            // (v^u) % N
            var innerModPow = BigInteger.ModPow(V, u, N);
            return BigInteger.ModPow(intA * innerModPow, _b, N);
        }

        private BigInteger GetRandom(int length) => GetBytes(length).ToBigInteger() % N;

        private BigInteger GetHashedCredentials(string password)
        {
            var temp = SHA1.HashData(Encoding.ASCII.GetBytes($"{I}:{password}".ToUpper()));
            var hash = SHA1.HashData(S.Concat(temp).ToArray());
            return hash.ToBigInteger();
        }

        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();
        public static byte[] GetBytes(int size)
        {
            var bytes = new byte[size];
            _rng.GetNonZeroBytes(bytes);
            return bytes;
        }
    }
}
