using Rabbit.SerializationMaster;
using StackExchange.Redis;
using System;

namespace Rabbit.Integrations.Redis
{
    public static class DatabaseExtensions
    {
        public static T Get<T>(this IDatabase database, RedisKey key) where T : class
        {
            var dataOnCache = database.StringGet(key);
            if (dataOnCache.IsNull)
            {
                return default(T);
            }

            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType((string)dataOnCache, typeof(T));
            }

            return ((string)dataOnCache).Deserialize<T>();
        }

        public static bool Set<T>(this IDatabase database, RedisKey key, T @object) where T : class
        {
            return database.StringSet(key, @object.Serialize());
        }

        public static bool Set<T>(this IDatabase database, RedisKey key, T @object, TimeSpan expiry) where T : class
        {
            return database.StringSet(key, @object.Serialize(), expiry);
        }
    }
}
