// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;

namespace WrathForged.Common.Cryptography;

public class RandomUtilities
{
    private const int RAND_LIST_LEN = 40;
    private readonly List<Random> _randoms = [];

    public RandomUtilities()
    {
        var seedGenerator = new Random();
        for (var i = 0; i < RAND_LIST_LEN; i++)
        {
            _randoms.Add(new Random(seedGenerator.Next()));
        }
    }

    public Random GetRandom() => _randoms[Environment.TickCount % RAND_LIST_LEN];
    private readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

    public byte[] RandomBytes(int length)
    {
        var bytes = new byte[length];
        _rng.GetNonZeroBytes(bytes);
        return bytes;
    }

    /// <summary>
    ///     Returns a random number within a specified range.
    /// </summary>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <returns></returns>
    public int IRand(int minValue, int maxValue) => GetRandom().Next(minValue, maxValue);

    // <summary>
    /// Returns a random number between 0.0 and 1.0. </summary> <returns> </returns>
    public double NextDouble() => GetRandom().NextDouble();

    public T RAND<T>(params T[] args)
    {
        var randIndex = IRand(0, args.Length - 1);

        return args[randIndex];
    }

    /// <summary>
    ///     Returns a nonnegative random number.
    /// </summary>
    /// <returns></returns>
    public uint Rand32() => (uint)GetRandom().Next();

    /// <summary>
    ///     Returns a nonnegative random number less than the specified maximum.
    /// </summary>
    /// <param name="maxValue"></param>
    /// <returns></returns>
    public uint Rand32(dynamic maxValue) => (uint)GetRandom().Next(maxValue);

    /// <summary>
    ///     Returns true if rand.Next less then i
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public bool RandChance(double i) => i > RandChance();

    /// <summary>
    ///     Returns true if rand.Next less then i
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public bool RandChance(float i) => i > RandChance();

    public double RandChance() => GetRandom().NextDouble() * 100.0;

    public float RandFloat() => (float)GetRandom().NextDouble();

    public uint RandShort() => (uint)GetRandom().Next(short.MaxValue);

    public TimeSpan RandTime(TimeSpan min, TimeSpan max)
    {
        var diff = max.TotalMilliseconds - min.TotalMilliseconds;

        return min + TimeSpan.FromMilliseconds(URand(0, (uint)diff));
    }

    public uint URand(dynamic minValue, dynamic maxValue) => (uint)GetRandom().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue));
}