using Rabbit.SerializationMaster;
using StackExchange.Redis;
using System;

namespace Rabbit.Integrations.Redis
{
    public static class DatabaseExtensions
    {
        public static string Get(this IDatabase database, RedisKey key)
        {
            return database.StringGet(key);
        }

        public static T Get<T>(this IDatabase database, RedisKey key) where T : class
        {
            var dataOnCache = database.StringGet(key);

            if (dataOnCache.IsNull)
            {
                return default(T);
            }

            return ((string)dataOnCache).Deserialize<T>();
        }

        public static bool Set<T>(this IDatabase database, RedisKey key, T @object) where T : class
        {
            if (typeof(T) == typeof(string))
            {
                return database.StringSet(key, (@object as string));
            }

            return database.StringSet(key, @object.Serialize());
        }

        public static bool Set<T>(this IDatabase database, RedisKey key, T @object, TimeSpan expiry) where T : class
        {
            if (typeof(T) == typeof(string))
            {
                return database.StringSet(key, (@object as string), expiry);
            }

            return database.StringSet(key, @object.Serialize(), expiry);
        }
    }
}
