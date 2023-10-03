// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Cryptography;

#pragma warning disable CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.

namespace WrathForged.Common
{
    public static class CollectionExtensionMethods
    {
        private static readonly RandomUtilities _randomUtilities = new();

        public static void Add<T, V>(this IDictionary<T, List<V>> dict, T key, V val)
        {
            if (dict == null)
                throw new ArgumentNullException(nameof(dict));

            if (!dict.TryGetValue(key, out var list))
            {
                list = [];
                dict.Add(key, list);
            }

            list.Add(val);
        }

        public static void Add<T, V>(this IDictionary<T, HashSet<V>> dict, T key, V val)
        {
            if (dict == null)
                throw new ArgumentNullException(nameof(dict));

            if (!dict.TryGetValue(key, out var list))
            {
                list = [];
                dict.Add(key, list);
            }

            _ = list.Add(val);
        }

        public static void Add<TKey1, TKey2, TVal>(this Dictionary<TKey1, Dictionary<TKey2, TVal>> dict, TKey1 key1, TKey2 key2, TVal newVal)
        {
            if (!dict.TryGetValue(key1, out var innerDict))
            {
                innerDict = [];
                dict[key1] = innerDict;
            }

            innerDict[key2] = newVal;
        }

        public static void AddIf<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, TValue value, Func<TValue, TValue, bool> testExistingVsNew)
        {
            if (!dict.TryGetValue(key, out var val))
            {
                val = [];
                dict.Add(key, val);
            }

            var ok = true;

            foreach (var kv in val)
            {
                if (!testExistingVsNew(kv, value))
                {
                    ok = false;

                    break;
                }
            }

            if (ok)
                val.Add(value);
        }

        public static void AddToDictList<T, L>(this Dictionary<T, List<L>> dict, T key, L item)
        {
            if (!dict.TryGetValue(key, out var list))
            {
                list = [];
                dict.Add(key, list);
            }

            list.Add(item);
        }

        public static void AddToList<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, TValue value)
        {
            if (!dict.TryGetValue(key, out var val))
            {
                val = [];
                dict.Add(key, val);
            }

            val.Add(value);
        }

        public static void AddToList<TKey, TValue>(this IDictionary<TKey, HashSet<TValue>> dict, TKey key, TValue value)
        {
            if (!dict.TryGetValue(key, out var val))
            {
                val = [];
                dict.Add(key, val);
            }

            _ = val.Add(value);
        }

        public static void AddToList<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, KeyValuePair<TKey, TValue> item) => dict.AddToList(item.Key, item.Value);

        public static void AddUniqueToList<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, TValue value)
        {
            if (!dict.TryGetValue(key, out var val))
            {
                val = [];
                dict.Add(key, val);
            }

            if (!val.Contains(value))
                val.Add(value);
        }

        /// <summary>
        ///     Calls the action for the first matching pred and returns. Allows the action to be
        ///     safely modify this map without getting enumeration exceptions
        /// </summary>
        public static bool CallOnFirstMatch<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred, Action<KeyValuePair<TKey, TValue>> action)
        {
            foreach (var item in dict.KeyValueList())
            {
                if (pred(item))
                {
                    action(item);

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Calls the action for the first matching pred and returns. Allows the action to be
        ///     safely modify this map without getting enumeration exceptions
        /// </summary>
        public static bool CallOnFirstMatch<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, Func<TValue, bool> pred, Action<TValue> action)
        {
            if (dict.TryGetValue(key, out var list))
            {
                foreach (var item in list)
                {
                    if (pred(item))
                    {
                        action(item);

                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        ///     Calls the action for each matching pred. Allows the action to be safely modify this
        ///     map without getting enumeration exceptions
        /// </summary>
        public static List<KeyValuePair<TKey, TValue>> CallOnMatch<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred, Action<KeyValuePair<TKey, TValue>> action)
        {
            var matches = new List<KeyValuePair<TKey, TValue>>();

            foreach (var item in dict.KeyValueList())
            {
                if (pred(item))
                {
                    matches.Add(item);
                    action(item);
                }
            }

            return matches;
        }

        public static void CallOnMatch<T>(this List<T> list, Func<T, bool> pred, Action<T> action)
        {
            for (var i = list.Count - 1; i >= 0; i--)
            {
                var item = list[i];

                if (pred(item))
                    action(item);
            }
        }

        public static void CallOnMatch<T>(this HashSet<T> list, Func<T, bool> pred, Action<T> action)
        {
            foreach (var item in list)
            {
                if (pred(item))
                    action(item);
            }
        }

        /// <summary>
        ///     Calls the action for each matching pred. Allows the action to be safely modify this
        ///     map without getting enumeration exceptions
        /// </summary>
        public static List<TValue> CallOnMatch<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, Func<TValue, bool> pred, Action<TValue> action)
        {
            var matches = new List<TValue>();

            if (dict.TryGetValue(key, out var list))
            {
                for (var i = list.Count - 1; i >= 0; i--)
                {
                    if (list.Count <= i)
                        continue;

                    var val = list[i];

                    if (pred(val))
                    {
                        matches.Add(val);
                        action(val);
                    }
                }
            }

            return matches;
        }

        public static void Clear(this Array array) => Array.Clear(array, 0, array.Length);

        public static bool Contains<TKey1, TVal>(this Dictionary<TKey1, List<TVal>> dict, TKey1 key, TVal val) => dict.TryGetValue(key, out var list) && list.Contains(val);

        public static bool ContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, object key)
        {
            var newkey = (TKey)Convert.ChangeType(key, typeof(TKey));

            return dict.ContainsKey(newkey);
        }

        public static bool ContainsKey<TKey1, TKey2, TVal>(this Dictionary<TKey1, Dictionary<TKey2, TVal>> dict, TKey1 key1, TKey2 key2) => dict.TryGetValue(key1, out var innerDict) && innerDict.ContainsKey(key2);

        public static bool Empty<T>(this Queue<T> queue) => queue == null || queue.Count == 0;

        public static bool Empty<TValue>(this ICollection<TValue> collection) => collection == null || collection.Count == 0;

        public static bool Empty<Tkey, TValue>(this IDictionary<Tkey, TValue> dictionary) => dictionary == null || dictionary.Count == 0;

        public static void EnsureWritableListIndex<T>(this List<T> list, int index, T defaultValue)
        {
            while (list.Count <= index)
                list.Add(defaultValue);
        }

        public static HashSet<int> Fill(this HashSet<int> set, int max)
        {
            for (var i = 0; i < max; i++)
                _ = set.Add(i);

            return set;
        }

        public static KeyValuePair<TKey, TValue> Find<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key) => !dict.TryGetValue(key, out var val) ? default : new KeyValuePair<TKey, TValue>(key, val);

        public static K GetOrAdd<T, K>(this Dictionary<T, K> dict, T key, Func<K> addKey)
        {
            if (!dict.TryGetValue(key, out var item))
            {
                item = addKey();
                dict.Add(key, item);
            }

            return item;
        }

        public static K GetOrAdd<T, T2, K>(this Dictionary<T, Dictionary<T2, K>> dict, T key, T2 key2, Func<K> addKey)
        {
            if (!dict.TryGetValue(key, out var item))
            {
                item = [];
                dict.Add(key, item);
            }

            return item.GetOrAdd(key2, addKey);
        }

        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, Func<TSource, TSource, bool> comparer) => first.Where(x => second.Count(y => comparer(x, y)) == 1);

        public static IEnumerable<KeyValuePair<TKey, TValue>> KeyValueList<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict)
        {
            foreach (var key in dict.Keys.ToList()) // this allows it to be safely enumerated off of and have items removed.
            {
                var val = dict[key];

                for (var i = val.Count - 1; i >= 0; i--)
                {
                    if (val.Count <= i)
                        continue;

                    yield return new KeyValuePair<TKey, TValue>(key, val[i]);
                }
            }
        }

        /// <summary>
        ///     Returns the entry in this list at the given index, or the default value of the
        ///     element type if the index was out of bounds.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list.</typeparam>
        /// <param name="list">The list to retrieve from.</param>
        /// <param name="index">The index to try to retrieve at.</param>
        /// <returns>The value, or the default value of the element type.</returns>
        public static T? LookupByIndex<T>(this IList<T> list, int index) => index >= list.Count ? default : list[index];

        /// <summary>
        ///     Returns the entry in this dictionary at the given key, or the default value of the
        ///     key if none.
        /// </summary>
        /// <typeparam name="TKey">The key type.</typeparam>
        /// <typeparam name="TValue">The value type.</typeparam>
        /// <param name="dict">The dictionary to operate on.</param>
        /// <param name="key">The key of the element to retrieve.</param>
        /// <returns>The value (if any).</returns>
        public static TValue? LookupByKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, object key)
        {
            var newkey = (TKey)Convert.ChangeType(key, typeof(TKey));

            return dict.TryGetValue(newkey, out var val) ? val : default;
        }

        public static TValue? LookupByKey<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key) => dict.TryGetValue(key, out var val) ? val : default;

        public static void RandomResize<T>(this IList<T> list, uint size)
        {
            var listSize = list.Count;

            while (listSize > size)
            {
                list.RemoveAt(_randomUtilities.IRand(0, listSize));
                --listSize;
            }
        }

        public static void RandomResize<T>(this IList<T> list, int size)
        {
            var listSize = list.Count;

            while (listSize > size)
            {
                list.RemoveAt(_randomUtilities.IRand(0, listSize));
                --listSize;
            }
        }

        public static void RandomResize<T>(this IList<T> list, double size)
        {
            var listSize = list.Count;

            while (listSize > size)
            {
                list.RemoveAt(_randomUtilities.IRand(0, listSize));
                --listSize;
            }
        }

        public static bool Remove<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, KeyValuePair<TKey, TValue> item)
        {
            if (!dict.TryGetValue(item.Key, out var valList))
                return false;

            var val = valList.Remove(item.Value);

            if (!val)
                return false;

            if (valList.Empty())
                _ = dict.Remove(item.Key);

            return true;
        }

        public static bool Remove<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, TValue value)
        {
            if (!dict.TryGetValue(key, out var valList))
                return false;

            var val = valList.Remove(value);

            if (!val)
                return false;

            if (valList.Empty())
                _ = dict.Remove(key);

            return true;
        }

        public static bool Remove<TKey, TValue>(this IDictionary<TKey, HashSet<TValue>> dict, TKey key, TValue value)
        {
            if (!dict.TryGetValue(key, out var valList))
                return false;

            var val = valList.Remove(value);

            if (!val)
                return false;

            if (valList.Empty())
                _ = dict.Remove(key);

            return true;
        }

        public static void Remove<T>(this List<T> list, List<T> toRemove)
        {
            foreach (var val in toRemove)
                _ = list.Remove(val);
        }

        public static void Remove<TKey, TValue>(this IDictionary<TKey, TValue> dict, List<TKey> toRemove)
        {
            foreach (var val in toRemove)
                _ = dict.Remove(val);
        }

        public static void Remove<TKey1, TKey2, TVal>(this Dictionary<TKey1, Dictionary<TKey2, TVal>> dict, TKey1 key1, TKey2 key2)
        {
            if (dict.TryGetValue(key1, out var innerDict))
            {
                _ = innerDict.Remove(key2);

                if (innerDict.Count == 0)
                    _ = dict.Remove(key1);
            }
        }

        public static void RemoveAll<T>(this List<T> collection, Func<T, bool> check) => collection.RemoveAll(check.Invoke);

        public static void RemoveAllMatchingKeys<TKey, TValue>(this IDictionary<TKey, TValue> dict, Func<TKey, bool> pred)
        {
            foreach (var key in dict.Keys.ToList())
            {
                if (pred.Invoke(key))
                    _ = dict.Remove(key);
            }
        }

        public static bool RemoveFirstMatching<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred, out KeyValuePair<TKey, TValue> foundValue)
        {
            foreach (var item in dict.KeyValueList())
            {
                if (pred(item))
                {
                    _ = dict.Remove(item.Key, item.Value);
                    foundValue = item;

                    return true;
                }
            }

            foundValue = default;

            return false;
        }

        public static bool RemoveFirstMatching<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred) => RemoveFirstMatching(dict, pred, out var _);

        public static void RemoveIf<T>(this LinkedList<T> values, Func<T, bool> func)
        {
            var toRemove = new List<T>();

            foreach (var v in values)
            {
                if (func.Invoke(v))
                    toRemove.Add(v);
            }

            foreach (var v in toRemove)
                _ = values.Remove(v);
        }

        public static void RemoveIf<T>(this List<T> values, Func<T, bool> func)
        {
            for (var i = values.Count - 1; i >= 0; i--)
            {
                if (func.Invoke(values[i]))
                    values.RemoveAt(i);
            }
        }

        /// <summary>
        ///     Removes all the entries of the matching expression
        /// </summary>
        /// <param name="pred">Expression to check to remove an item</param>
        /// <returns>List of removed key/value pairs.</returns>
        public static List<KeyValuePair<TKey, TValue>> RemoveIfMatching<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred)
        {
            var toRemove = new List<KeyValuePair<TKey, TValue>>();

            foreach (var item in dict.KeyValueList())
            {
                if (pred(item))
                {
                    toRemove.Add(item);
                    _ = dict.Remove(item.Key, item.Value);
                }
            }

            return toRemove;
        }

        public static void RemoveIfMatching<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, TKey key, Func<TValue, bool> pred)
        {
            if (dict.TryGetValue(key, out var values))
            {
                for (var i = values.Count - 1; i >= 0; i--)
                {
                    if (values.Count <= i)
                        continue;

                    var val = values[i];

                    if (pred.Invoke(val))
                        _ = values.Remove(val);
                }
            }
        }

        /// <summary>
        ///     Removes all the entries of the matching expression
        /// </summary>
        /// <param name="pred">Expression to check to remove an item</param>
        /// <returns>Multimap of removed values.</returns>
        public static void RemoveIfMatchingMulti<TKey, TValue>(this IDictionary<TKey, List<TValue>> dict, Func<KeyValuePair<TKey, TValue>, bool> pred)
        {
            foreach (var item in dict.KeyValueList())
            {
                if (pred(item))
                    _ = dict.Remove(item.Key, item.Value);
            }
        }

        public static void Resize<T>(this List<T?> list, uint size)
        {
            var cur = list.Count;

            if (size < cur)
            {
                list.RemoveRange((int)size, cur - (int)size);
            }
            else
            {
                for (var i = list.Count; i < size; ++i)
                    list.Add(default);
            }
        }

        public static T SelectRandom<T>(this IEnumerable<T> source) => source.SelectRandom(1).Single();

        public static IEnumerable<T> SelectRandom<T>(this IEnumerable<T> source, uint count) => source.Shuffle().Take((int)count);

        public static IEnumerable<T> SelectRandom<T>(this IEnumerable<T> source, int count) => source.Shuffle().Take(count);

        public static T? SelectRandomElementByWeight<T>(this IEnumerable<T> sequence, Func<T, float> weightSelector)
        {
            var totalWeight = sequence.Sum(weightSelector);
            // The weight we are after...
            var itemWeightIndex = _randomUtilities.RandFloat() * totalWeight;
            float currentWeightIndex = 0;

            foreach (var item in from weightedItem in sequence
                                 select new
                                 {
                                     Value = weightedItem,
                                     Weight = weightSelector(weightedItem)
                                 })
            {
                currentWeightIndex += item.Weight;

                // If we've hit or passed the weight we are after for this item then it's the one we want....
                if (currentWeightIndex >= itemWeightIndex)
                    return item.Value;
            }

            return default;
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source) => source.OrderBy(x => Random.Shared.Next());

        public static void Swap<T>(this T[] array, int position1, int position2) =>
            // Swaps elements in an array. Doesn't need to return a reference.
            (array[position2], array[position1]) = (array[position1], array[position2]);         // Copy the first position's element

        public static int ToMask(this IEnumerable<int> set)
        {
            var mask = 0;

            foreach (var i in set)
                mask |= 1 << i;

            return mask;
        }

        public static uint ToUMask(this IEnumerable<int> set)
        {
            uint mask = 0;

            foreach (var i in set)
                mask |= 1u << i;

            return mask;
        }

        public static bool TryGetValue<TKey1, TKey2, TVal>(this Dictionary<TKey1, Dictionary<TKey2, TVal>> dict, TKey1 key1, TKey2 key2, out TVal? val)
        {
            val = default;

            return dict.TryGetValue(key1, out var innerDict) && innerDict.TryGetValue(key2, out val);
        }
    }
}