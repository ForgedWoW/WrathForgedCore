using System.Security.Cryptography;

namespace WrathForged.Common.Cryptography
{
    public static class HashUtil
    {
        public static byte[] ComputeHash(params byte[][] args)
        {
            return SHA1.HashData(args.SelectMany(b => b).ToArray());
        }
    }
}
