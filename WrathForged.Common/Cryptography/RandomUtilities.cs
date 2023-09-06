// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Cryptography
{
    public class RandomUtilities
    {
        private const int RAND_LIST_LEN = 40;
        private readonly List<Random> _randoms = new();

        public RandomUtilities()
        {
            var seendGenerator = new Random();
            for (var i = 0; i < RAND_LIST_LEN; i++)
            {
                _randoms.Add(new Random(seendGenerator.Next()));
            }
        }

        public Random GetRandom() => _randoms[Environment.TickCount % RAND_LIST_LEN];

        public byte[] RandomBytes(int length)
        {
            var bytes = new byte[length];
            GetRandom().NextBytes(bytes);
            return bytes;
        }
    }
}