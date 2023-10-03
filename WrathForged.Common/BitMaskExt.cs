// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common;

public static class BitMaskExt
{
    public static HashSet<int> ExplodeMask(this uint mask, HashSet<int> maxValues)
    {
        var newSet = new HashSet<int>();

        foreach (var i in maxValues)
        {
            if ((mask & (1 << i)) != 0)
                _ = newSet.Add(i);
        }

        return newSet;
    }

    public static HashSet<int> ExplodeMask(this uint mask, int maxValue) => mask.ExplodeMask(new HashSet<int>().Fill(maxValue));

    public static HashSet<int> ExplodeMask(this int mask, HashSet<int> maxValues)
    {
        var newSet = new HashSet<int>();

        foreach (var i in maxValues)
        {
            if ((mask & (1 << i)) != 0)
                _ = newSet.Add(i);
        }

        return newSet;
    }

    public static HashSet<int> ExplodeMask(this int mask, int maxValue) => mask.ExplodeMask(new HashSet<int>().Fill(maxValue));

    public static HashSet<TEnum> ExplodeEnumMask<TEnum>(this uint mask) where TEnum : Enum
    {
        var newSet = new HashSet<TEnum>();
        foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
        {
            var intValue = Convert.ToInt32(value);
            if ((mask & (1 << intValue)) != 0)
            {
                _ = newSet.Add(value);
            }
        }

        return newSet;
    }

    public static HashSet<TEnum> ExplodeEnumMask<TEnum>(this int mask) where TEnum : Enum
    {
        var newSet = new HashSet<TEnum>();
        foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
        {
            var intValue = Convert.ToInt32(value);
            if ((mask & (1 << intValue)) != 0)
            {
                _ = newSet.Add(value);
            }
        }

        return newSet;
    }

    // Implode methods for int and uint
    public static uint ImplodeMask(this HashSet<int> set)
    {
        uint mask = 0;
        foreach (var i in set)
        {
            mask |= (uint)(1 << i);
        }

        return mask;
    }

    public static int ImplodeMaskToInt(this HashSet<int> set)
    {
        var mask = 0;
        foreach (var i in set)
        {
            mask |= 1 << i;
        }

        return mask;
    }

    // Implode methods for enum
    public static uint ImplodeEnumMask<TEnum>(this HashSet<TEnum> set) where TEnum : Enum
    {
        uint mask = 0;
        foreach (var value in set)
        {
            var intValue = Convert.ToInt32(value);
            mask |= (uint)(1 << intValue);
        }

        return mask;
    }

    public static int ImplodeEnumMaskToInt<TEnum>(this HashSet<TEnum> set) where TEnum : Enum
    {
        var mask = 0;
        foreach (var value in set)
        {
            var intValue = Convert.ToInt32(value);
            mask |= 1 << intValue;
        }

        return mask;
    }
}