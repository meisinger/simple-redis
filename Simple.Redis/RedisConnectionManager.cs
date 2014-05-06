using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple.Redis
{
    public static class RedisConnectionManager
    {
        private static readonly Dictionary<string, RedisConnectionPool> dictionary =
            new Dictionary<string, RedisConnectionPool>();

        public static RedisConnectionPool IdentifyConnectionPool(string hostName, int portNumber, int poolSize, TimeSpan timeout)
        {
            lock (dictionary)
            {
                RedisConnectionPool pool;

                var uniqueKey = string.Format("{0}::{1}", hostName, portNumber);
                if (!dictionary.TryGetValue(uniqueKey, out pool))
                {
                    pool = new RedisConnectionPool(hostName, portNumber, poolSize, timeout);
                    dictionary[uniqueKey] = pool;
                }

                return pool;
            }
        }

        public static void DisposeConnectionPool()
        {
            lock (dictionary)
            {
                var pools = dictionary.Values.ToArray();
                for (int index = 0; index < pools.Length; index++)
                {
                    var pool = pools[index];
                    pool.Dispose();
                }
            }
        }
    }
}
