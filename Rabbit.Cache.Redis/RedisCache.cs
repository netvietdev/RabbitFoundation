﻿using Rabbit.SerializationMaster;
using StackExchange.Redis;
using System;

namespace Rabbit.Cache.Redis
{
    public class RedisCache : ICache
    {
        private readonly IDatabase _database;

        public RedisCache(IDatabase database)
        {
            _database = database;
        }

        public T Get<T>(string key) where T : class
        {
            var dataInCache = _database.StringGet(key);

            if (dataInCache.IsNull)
            {
                return default(T);
            }

            return ((string)dataInCache).Deserialize<T>();
        }

        public bool Set<T>(string key, T value) where T : class
        {
            return _database.StringSet(key, value.Serialize());
        }

        public bool Set<T>(string key, T value, TimeSpan expiry) where T : class
        {
            return _database.StringSet(key, value.Serialize(), expiry);
        }

        public bool Remove(string key)
        {
            return _database.KeyDelete(key);
        }
    }
}
