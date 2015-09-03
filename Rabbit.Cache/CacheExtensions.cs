using System;

namespace Rabbit.Cache
{
    public static class CacheExtensions
    {
        public static T GetOrExecute<T>(this ICache cache, string key, Func<T> function) where T : class
        {
            var value = cache.Get<T>(key);
            if (value != null)
            {
                return value;
            }

            return function();
        }
    }
}