// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;

namespace WrathForged.Common.Cryptography
{
    public class GenericHash
    {
        public static readonly int DIGEST_LENGTH = SHA1.Create().HashSize / 8;
        public byte[] Digest { get; private set; } = new byte[DIGEST_LENGTH];

        public static byte[] GetDigestOf(byte[] data)
        {
            var hash = new GenericHash();
            hash.UpdateData(data);
            hash.FinalizeHash();
            return hash.Digest;
        }

        public static byte[] GetDigestOf(params object[] pack)
        {
            var hash = new GenericHash();
            foreach (var item in pack)
            {
                if (item is byte[] byteArray)
                {
                    hash.UpdateData(byteArray);
                }
                else if (item is string str)
                {
                    hash.UpdateData(str);
                }
            }
            hash.FinalizeHash();
            return hash.Digest;
        }

        private readonly SHA1 _hashAlgorithm;

        public GenericHash()
        {
            _hashAlgorithm = SHA1.Create();
        }

        public void UpdateData(byte[] data)
        {
            _hashAlgorithm.TransformBlock(data, 0, data.Length, null, 0);
        }

        public void UpdateData(string str)
        {
            UpdateData(System.Text.Encoding.UTF8.GetBytes(str));
        }

        public void UpdateData(IEnumerable<byte> container)
        {
            UpdateData(container.ToArray());
        }

        public void FinalizeHash()
        {
            _hashAlgorithm.TransformFinalBlock([], 0, 0);
            Digest = _hashAlgorithm.Hash ?? (new byte[DIGEST_LENGTH]);
        }
    }

}
