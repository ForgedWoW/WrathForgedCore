// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Common.Util
{
    public static class FlagsUtil
    {
        /// <summary>
        /// Creates and returns an array of all indices that are set within the given flag field.
        /// eg. {11000011, 11000011} would result into an array containing: 0,1,6,7,8,9,14,15
        /// </summary>
        public static uint[] GetSetIndices(uint[] flagsArr)
        {
            var indices = new List<uint>();
            foreach (var flags in flagsArr)
            {
                GetSetIndices(indices, flags);
            }

            return indices.ToArray();
        }

        public static uint Sum(this IEnumerable<uint> arr) => arr.Aggregate(0u, (current, n) => current + n);

        /// <summary>
        /// Creates and returns an array of all indices that are set within the given flag field.
        /// eg. 11000011 would result into an array containing: 0,1,6,7
        /// </summary>
        public static uint[] GetSetIndices(uint flags)
        {
            var indices = new List<uint>();
            GetSetIndices(indices, flags);
            return indices.ToArray();
        }

        public static T[] GetSetIndicesEnum<T>(T flags) where T : Enum
        {
            var indices = new List<uint>();
            var uintFlags = (uint)Convert.ChangeType(flags, typeof(uint));
            GetSetIndices(indices, uintFlags);
            if (indices.Count == 0)
            {
                object box = (uint)0;
                return new[] { (T)box };
            }

            var arr = new T[indices.Count];
            for (var i = 0; i < indices.Count; i++)
            {
                var index = indices[i];
                object box = (uint)(1 << (int)index);
                arr[i] = (T)box;
            }

            return arr;
        }

        public static void GetSetIndices(List<uint> indices, uint flags)
        {
            for (uint i = 0; i < 32; i++)
            {
                if ((flags & (1 << (int)i)) != 0)
                {
                    indices.Add(i);
                }
            }
        }

        /// <summary>
        /// Creates and returns an array of all indices that are set within the given flag field.
        /// eg. 11000011 would result into an array containing: 0,1,6,7
        /// </summary>
        public static T[] GetSetIndices<T>(uint flags)
        {
            var indices = new List<T>(5);
            for (uint i = 0; i < 32; i++)
            {
                if ((flags & (1 << (int)i)) != 0)
                {
                    if (typeof(T).IsEnum)
                    {
                        indices.Add((T)Enum.Parse(typeof(T), i.ToString()));
                    }
                    else
                    {
                        indices.Add((T)Convert.ChangeType(i, typeof(T)));
                    }
                }
            }

            return indices.ToArray();
        }
    }
}