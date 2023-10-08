// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace WrathForged.Common.Cryptography
{
    public class Authenticator
    {
        public byte[] Salt { get; private set; }
        public byte[] RN { get; private set; } = SRP6.N.Reverse().ToArray();
        public BigInteger B { get; private set; }
        public BigInteger V { get; private set; }
        public byte[] RB { get; private set; }
        public static BigInteger K { get; private set; } = new BigInteger(new byte[] { 3 });
        public static BigInteger G { get; private set; } = new BigInteger(new byte[] { 7 });
        public byte[] BUsername { get; private set; }

        public static Authenticator Default => new();

        private Authenticator()
        {
            Salt = [];
            BUsername = [];
            V = new BigInteger();
            B = new BigInteger();
            RB = [];
        }

        public Authenticator(string username, byte[] salt, BigInteger verifier)
        {
            Salt = salt;
            BUsername = Encoding.ASCII.GetBytes(username.ToUpper());

            RB = new byte[20];

            using RandomNumberGenerator _rng = RandomNumberGenerator.Create();
            _rng.GetNonZeroBytes(RB);

            B = ((K * V) + G.ModPow(new BigInteger(RB), new BigInteger(RN))) % new BigInteger(RN);
        }


        public (byte[] ClientProof, byte[] ServerProof, byte[] SessionKey) LogonProof(byte[] A, byte[] kM1)
        {
            byte[] rA = A.Reverse().ToArray();
            byte[] AB = A.Concat(B.GetBytes(32).Reverse()).ToArray();

            using (SHA1 sha1 = SHA1.Create())
            {
                // SS_Hash
                byte[] rU = sha1.ComputeHash(AB).Reverse().ToArray();
                var s = V.ModPow(new BigInteger(rU), new BigInteger(RN)) * new BigInteger(rA);
                s = s.ModPow(new BigInteger(RB), new BigInteger(RN));

                byte[] S1 = new byte[16], S2 = new byte[16];
                byte[] rS = s.GetBytes(32).Reverse().ToArray();
                for (int t = 0; t < 16; t++)
                {
                    S1[t] = rS[t * 2];
                    S2[t] = rS[(t * 2) + 1];
                }

                byte[] hashS1 = sha1.ComputeHash(S1), hashS2 = sha1.ComputeHash(S2);
                byte[] ss_hash = new byte[hashS1.Length + hashS2.Length];
                for (int t = 0; t < hashS1.Length; t++)
                {
                    ss_hash[t * 2] = hashS1[t];
                    ss_hash[(t * 2) + 1] = hashS2[t];
                }

                // calc M1 & M2
                byte[] NHash = sha1.ComputeHash(SRP6.N);
                byte[] GHash = sha1.ComputeHash(G.ToProperByteArray());

                var tmp = Enumerable.Range(0, 20)
                                    .Select(t => (byte)(NHash[t] ^ GHash[t]))
                                    .Concat(sha1.ComputeHash(BUsername))
                                    .Concat(Salt)
                                    .Concat(A)
                                    .Concat(B.ToProperByteArray().Reverse())
                                    .Concat(ss_hash);

                byte[] M1 = sha1.ComputeHash(tmp.ToArray());
                byte[] M2 = sha1.ComputeHash(A.Concat(M1).Concat(ss_hash).ToArray());


                return (M1, M2, ss_hash);
            }
        }

    }
}
