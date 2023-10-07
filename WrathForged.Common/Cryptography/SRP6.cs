// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

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
        private static readonly BigInteger _n = BigInteger.Parse("894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7", NumberStyles.HexNumber);

        public static readonly byte[] G = _g.ToByteArray();
        public static readonly byte[] N = _n.ToByteArray();

        public static Tuple<byte[], byte[]> MakeRegistrationData(string username, string password)
        {
            byte[] salt = _crypto.RandomBytes(SALT_LENGTH);
            byte[] verifier = CalculateVerifier(username, password, salt);
            return new Tuple<byte[], byte[]>(salt, verifier);
        }

        public static bool CheckLogin(string username, string password, byte[] salt, byte[] verifier)
        {
            return verifier.SequenceEqual(CalculateVerifier(username, password, salt));
        }

        public static byte[] GetSessionVerifier(byte[] A, byte[] clientM, byte[] K)
        {
            return SHA1.HashData(A.Concat(clientM).Concat(K).ToArray());
        }

        private static byte[] CalculateVerifier(string username, string password, byte[] salt)
        {
            return BigInteger.ModPow(_g,
                SHA1.HashData(
                    salt.Concat(
                        SHA1.HashData(
                            System.Text.Encoding.UTF8.GetBytes(username + ":" + password)
                        )
                    ).ToArray()
                ).ToPositiveBigInteger(),
                _n
            ).ToByteArray();
        }

        private static byte[] SHA1Interleave(byte[] S)
        {
            // Constants
            const int EPHEMERAL_KEY_LENGTH = 32;
            const int SHA1_DIGEST_LENGTH = 20;

            // Split S into two buffers
            byte[] buf0 = new byte[EPHEMERAL_KEY_LENGTH / 2];
            byte[] buf1 = new byte[EPHEMERAL_KEY_LENGTH / 2];
            for (int i = 0; i < EPHEMERAL_KEY_LENGTH / 2; ++i)
            {
                buf0[i] = S[2 * i + 0];
                buf1[i] = S[2 * i + 1];
            }

            // Find position of first nonzero byte
            int p = 0;
            while (p < EPHEMERAL_KEY_LENGTH && S[p] == 0)
                ++p;
            if ((p & 1) == 1)
                ++p; // Skip one extra byte if p is odd
            p /= 2; // Offset into buffers

            // Hash each of the halves, starting at the first nonzero byte
            byte[] hash0 = SHA1.HashData(buf0.Skip(p).ToArray());
            byte[] hash1 = SHA1.HashData(buf1.Skip(p).ToArray());

            // Stick the two hashes back together
            byte[] K = new byte[SHA1_DIGEST_LENGTH * 2];
            for (int i = 0; i < SHA1_DIGEST_LENGTH; ++i)
            {
                K[2 * i + 0] = hash0[i];
                K[2 * i + 1] = hash1[i];
            }
            return K;
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
            _i = SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(username));
            _b = _crypto.RandomBytes(32).ToPositiveBigInteger();
            _v = verifier.ToPositiveBigInteger();
            Salt = salt;
            B = ((BigInteger.ModPow(_g, _b, _n) + (_v * 3)) % _n).ToByteArray();
        }

        public byte[]? VerifyChallengeResponse(byte[] a, byte[] clientM)
        {
            BigInteger aaBigInt = a.ToPositiveBigInteger();

            if ((aaBigInt % _n) == 0)
            {
                return null;
            }

            BigInteger u = new BigInteger(SHA1.HashData(a.Concat(B).ToArray()));
            BigInteger S = (aaBigInt * (BigInteger.ModPow(BigInteger.ModPow(_v, u, _n), _b, _n)));
            byte[] k = SHA1Interleave(S.ToProperByteArray());

            byte[] NHash = SHA1.HashData(N);
            byte[] gHash = SHA1.HashData(G);
            byte[] NgHash = NHash.Zip(gHash, (n, g) => (byte)(n ^ g)).ToArray();
            SHA1 sha1 = SHA1.Create();

            byte[] ourM = SHA1.HashData(NgHash.Concat(_i).Concat(S.ToProperByteArray()).Concat(a).Concat(B).Concat(k).ToArray());

            return ourM.SequenceEqual(clientM) ? k : null;
        }
    }
}

