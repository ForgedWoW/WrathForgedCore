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
        public static RandomUtilities Crypto = new RandomUtilities();
        public const int SALT_LENGTH = 32;
        public const int VERIFIER_LENGTH = 32;
        public const int EPHEMERAL_KEY_LENGTH = 32;


        private static readonly BigInteger _g = new BigInteger(7);
        private static readonly BigInteger _n = BigInteger.Parse("894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7", NumberStyles.HexNumber);

        public static readonly byte[] G = _g.ToByteArray();
        public static readonly byte[] N = _n.ToByteArray();

        public static Tuple<byte[], byte[]> MakeRegistrationData(string username, string password)
        {
            byte[] salt = Crypto.RandomBytes(SALT_LENGTH);
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

        private bool _used = false;
        private readonly byte[] _i;
        private readonly BigInteger _b;
        private readonly BigInteger _v;

        public readonly byte[] Salt;
        public readonly byte[] B;

        public static SRP6 Default { get; } = new SRP6();

        private SRP6()
        {
            _i = new byte[32];
            _b = new BigInteger();
            _v = new BigInteger();
            Salt = new byte[32];
            B = new byte[32];
        }

        public SRP6(string username, byte[] salt, byte[] verifier)
        {
            _i = SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(username));
            _b = new BigInteger(Crypto.RandomBytes(32));
            _v = new BigInteger(verifier);
            Salt = salt;
            B = GenerateB(_b, _v);
        }

        private byte[] GenerateB(BigInteger b, BigInteger v)
        {
            return ((BigInteger.ModPow(_g, b, _n) + (v * 3)) % _n).ToByteArray();
        }

        public byte[]? VerifyChallengeResponse(byte[] A, byte[] clientM)
        {
            if (_used)
            {
                throw new InvalidOperationException("A single SRP6 object must only ever be used to verify ONCE!");
            }
            _used = true;
            BigInteger _A = new BigInteger(A);
            if ((_A % _n) == 0)
            {
                return null;
            }

            BigInteger u = new BigInteger(SHA1.HashData(A.Concat(B).ToArray()));
            BigInteger S = (_A * (BigInteger.ModPow(BigInteger.ModPow(_v, u, _n), _b, _n)));
            byte[] K = Interleave(S).ToProperByteArray();

            byte[] NHash = SHA1.HashData(N);
            byte[] gHash = SHA1.HashData(G);
            byte[] NgHash = NHash.Zip(gHash, (n, g) => (byte)(n ^ g)).ToArray();
            SHA1 sha1 = SHA1.Create();

            byte[] ourM = SHA1.HashData(NgHash.Concat(_i).Concat(S.ToProperByteArray()).Concat(A).Concat(B).Concat(K).ToArray());

            if (ourM.SequenceEqual(clientM))
            {
                return K;
            }
            else
            {
                return null;
            }
        }
    }
}

