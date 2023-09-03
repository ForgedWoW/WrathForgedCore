// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Runtime.Caching;

namespace WrathForged.Common
{
    public class ForgeCache
    {
        private readonly MemoryCache _cache = new("ForgeCache");
        private readonly Dictionary<string, Func<object>> _refreshFunctions = new();

        public T? Get<T>(string key)
        {
            if (!_cache.Contains(typeof(T).Name))
                return default;

            return (T)_cache.Get(key);
        }

        public T? Get<T>()
        {
            if (!_cache.Contains(typeof(T).Name))
                return default;

            return (T)_cache.Get(typeof(T).Name);
        }

        public bool TryGet<T>(out T? value)
        {
            if (!_cache.Contains(typeof(T).Name))
            {
                value = default;
                return false;
            }

            value = (T)_cache.Get(typeof(T).Name);
            return true;
        }

        public bool TryGet<T>(string key, out T? value)
        {
            if (!_cache.Contains(key))
            {
                value = default;
                return false;
            }

            value = (T)_cache.Get(key);
            return true;
        }

        public void Set<T>(TimeSpan expiration, Func<T> refresh)
        {
            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            var value = refresh() ?? throw new InvalidDataException(nameof(refresh) + $" returned null data");

            Set(value.GetType().Name, value, expiration, refresh);
        }

        public void Set<T>(string key, TimeSpan expiration, Func<T> refresh)
        {
            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            var value = refresh() ?? throw new InvalidDataException(nameof(refresh) + $" returned null data for key {key}");

            Set(key, value, expiration, refresh);
        }

        public void Set<T>(T value, TimeSpan expiration, Func<T> refresh)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            Set(value.GetType().Name, value, expiration, refresh);
        }

        public void Set<T>(string key, T value, TimeSpan expiration, Func<T> refresh)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Must be set", nameof(key));

            _refreshFunctions[key] = () => refresh();
            _cache.Set(key, value, new CacheItemPolicy()
            {
                AbsoluteExpiration = DateTime.UtcNow.Add(expiration),
                RemovedCallback = (arguments) =>
                {
                    if (arguments.RemovedReason == CacheEntryRemovedReason.Expired)
                        Set(key, refresh(), expiration, refresh);
                }
            });
        }

        public void Set<T>(string key, T value, TimeSpan expiration)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Must be set", nameof(key));

            _cache.Set(key, value, new CacheItemPolicy() { AbsoluteExpiration = DateTime.UtcNow.Add(expiration) });
        }

        public void UpdateKey(string key)
        {
            // Check if the refresh function exists for the given key
            if (_refreshFunctions.TryGetValue(key, out var refreshFunc))
            {
                // Invoke the refresh function to get the updated value
                var updatedValue = refreshFunc();

                // Retrieve the current cache item's policy
                var cacheItemPolicy = _cache.Get(key) as CacheItemPolicy;

                // Update the cache with the new value
                if (cacheItemPolicy != null)
                {
                    _cache.Set(key, updatedValue, cacheItemPolicy);
                }
            }
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
            _refreshFunctions.Remove(key);
        }
    }
}