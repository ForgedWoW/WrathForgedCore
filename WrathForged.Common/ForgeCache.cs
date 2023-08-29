// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Runtime.Caching;

namespace WrathForged.Common
{
    public class ForgeCache
    {
        private readonly MemoryCache _cache = new("ForgeCache");

        public T Get<T>(string key)
        {
            return (T)_cache.Get(key);
        }

        public T Get<T>()
        {
            return (T)_cache.Get(typeof(T).Name);
        }

        public void Set<T>(TimeSpan expiration, Func<T> refresh)
        {
            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            var value = refresh();

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            Set(value.GetType().Name, value, expiration, refresh);
        }

        public void Set<T>(string key, TimeSpan expiration, Func<T> refresh)
        {
            if (refresh == null)
                throw new ArgumentNullException(nameof(refresh));

            if (expiration == TimeSpan.Zero)
                throw new ArgumentException("Must be greater than zero", nameof(expiration));

            var value = refresh();

            if (value == null)
                throw new ArgumentNullException(nameof(value));

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

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}