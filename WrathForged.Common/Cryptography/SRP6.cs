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
    public class SRP6
    {
        private static readonly RandomUtilities _crypto = new();
        public const int SALT_LENGTH = 32;
        public const int VERIFIER_LENGTH = 32;
        public const int EPHEMERAL_KEY_LENGTH = 32;


        private static readonly BigInteger _g = new(7);
        private static readonly BigInteger _n = new(new byte[]
            {
                0x89, 0x4B, 0x64, 0x5E, 0x89, 0xE1, 0x53, 0x5B, 0xBD, 0xAD, 0x5B, 0x8B, 0x29, 0x06, 0x50, 0x53,
                0x08, 0x01, 0xB1, 0x8E, 0xBF, 0xBF, 0x5E, 0x8F, 0xAB, 0x3C, 0x82, 0x87, 0x2A, 0x3E, 0x9B, 0xB7,
            }, true, true);

        public static readonly byte[] G = _g.ToProperByteArray();
        public static readonly byte[] N = _n.ToProperByteArray();

        public static (byte[] Salt, byte[] Verifier) MakeRegistrationData(string username, string password)
        {
            byte[] salt = (_crypto.RandomBytes(SALT_LENGTH).ToBigInteger() % _n).ToProperByteArray();
            byte[] verifier = GenerateVerifier(username, password, salt);
            return (salt, verifier);
        }

        public static byte[] GetSessionVerifier(byte[] A, byte[] clientM, byte[] K)
        {
            return SHA1.HashData(A.Concat(clientM).Concat(K).ToArray());
        }

        private static byte[] GenerateVerifier(string username, string password, byte[] salt)
        {
            return BigInteger.ModPow(_g, new BigInteger(SHA1.HashData(salt.Combine(SHA1.HashData(Encoding.UTF8.GetBytes(username.ToUpperInvariant() + ":" + password.ToUpperInvariant())))), true), _n).ToProperByteArray();
        }

        private static byte[] SHA1Interleave(byte[] S)
        {
            var T = S.SkipWhile(b => b == 0).ToArray(); // Remove all leading 0-bytes

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

            return result;
        }

        private readonly byte[] _i;
        private readonly BigInteger _b;
        private readonly BigInteger _v;

        public readonly byte[] Salt;
        public readonly byte[] B;

        public static SRP6 Default { get; } = new SRP6();

        private SRP6()
        {
            _i = new byte[32];
            _b = default;
            _v = default;
            Salt = new byte[32];
            B = new byte[32];
        }

        public SRP6(string username, byte[] salt, byte[] verifier)
        {
            _i = SHA1.HashData(Encoding.UTF8.GetBytes(username));
            _b = _crypto.RandomBytes(32).ToBigInteger();
            _v = verifier.ToBigInteger();
            Salt = salt;
            B = ((BigInteger.ModPow(_g, _b, _n) + (_v * 3)) % _n).ToProperByteArray();
        }

        public byte[]? VerifyChallengeResponse(byte[] a, byte[] clientM)
        {
            BigInteger aaBigInt = a.ToBigInteger();

            if ((aaBigInt % _n) == 0)
            {
                return null;
            }

            BigInteger u = SHA1.HashData(a.Concat(B).ToArray()).ToBigInteger();
            byte[] k = SHA1Interleave(BigInteger.ModPow(aaBigInt * BigInteger.ModPow(_v, u, _n), _b, _n).ToProperByteArray());

            byte[] NHash = SHA1.HashData(N);
            byte[] gHash = SHA1.HashData(G);

            for (int i = 0, j = NHash.Length; i < j; i++)
                NHash[i] ^= gHash[i];

            byte[] ourM = SHA1.HashData(NHash.Concat(_i).Concat(Salt).Concat(a).Concat(B).Concat(k).ToArray());

            return ourM.SequenceEqual(clientM) ? k : null;
        }
    }
}

