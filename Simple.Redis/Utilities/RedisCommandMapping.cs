using System;
using System.Collections.Generic;

namespace Simple.Redis.Utilities
{
    public static class RedisCommandMapping
    {
        private static readonly Dictionary<string, byte[][]> mapping;

        static RedisCommandMapping()
        {
            mapping = new Dictionary<string, byte[][]>();

            mapping[RedisCommands.APPEND] = new byte[][] { new byte[] { 65, 80, 80, 69, 78, 68 } };
            mapping[RedisCommands.AUTH] = new byte[][] { new byte[] { 65, 85, 84, 72 } };
            mapping[RedisCommands.BGREWRITEAOF] = new byte[][] { new byte[] { 66, 71, 82, 69, 87, 82, 73, 84, 69, 65, 79, 70 } };
            mapping[RedisCommands.BGSAVE] = new byte[][] { new byte[] { 66, 71, 83, 65, 86, 69 } };
            mapping[RedisCommands.BITCOUNT] = new byte[][] { new byte[] { 66, 73, 84, 67, 79, 85, 78, 84 } };
            mapping[RedisCommands.BITOP] = new byte[][] { new byte[] { 66, 73, 84, 79, 80 } };
            mapping[RedisCommands.BITPOS] = new byte[][] { new byte[] { 66, 73, 84, 80, 79, 83 } };
            mapping[RedisCommands.BLPOP] = new byte[][] { new byte[] { 66, 76, 80, 79, 80 } };
            mapping[RedisCommands.BRPOP] = new byte[][] { new byte[] { 66, 82, 80, 79, 80 } };
            mapping[RedisCommands.BRPOPLPUSH] = new byte[][] { new byte[] { 66, 82, 80, 79, 80, 76, 80, 85, 83, 72 } };
            mapping[RedisCommands.CLIENTKILL] = new byte[][] { new byte[] { 67, 76, 73, 69, 78, 84 }, new byte[] { 75, 73, 76, 76 } };
            mapping[RedisCommands.CLIENTLIST] = new byte[][] { new byte[] { 67, 76, 73, 69, 78, 84 }, new byte[] { 76, 73, 83, 84 } };
            mapping[RedisCommands.CLIENTGETNAME] = new byte[][] { new byte[] { 67, 76, 73, 69, 78, 84 }, new byte[] { 71, 69, 84, 78, 65, 77, 69 } };
            mapping[RedisCommands.CLIENTPAUSE] = new byte[][] { new byte[] { 67, 76, 73, 69, 78, 84 }, new byte[] { 80, 65, 85, 83, 69 } };
            mapping[RedisCommands.CLIENTSETNAME] = new byte[][] { new byte[] { 67, 76, 73, 69, 78, 84 }, new byte[] { 83, 69, 84, 78, 65, 77, 69 } };
            mapping[RedisCommands.CONFIGGET] = new byte[][] { new byte[] { 67, 79, 78, 70, 73, 71 }, new byte[] { 71, 69, 84 } };
            mapping[RedisCommands.CONFIGREWRITE] = new byte[][] { new byte[] { 67, 79, 78, 70, 73, 71 }, new byte[] { 82, 69, 87, 82, 73, 84, 69 } };
            mapping[RedisCommands.CONFIGSET] = new byte[][] { new byte[] { 67, 79, 78, 70, 73, 71 }, new byte[] { 83, 69, 84 } };
            mapping[RedisCommands.CONFIGRESETSTAT] = new byte[][] { new byte[] { 67, 79, 78, 70, 73, 71 }, new byte[] { 82, 69, 83, 69, 84, 83, 84, 65, 84 } };
            mapping[RedisCommands.DBSIZE] = new byte[][] { new byte[] { 68, 66, 83, 73, 90, 69 } };
            mapping[RedisCommands.DEBUGOBJECT] = new byte[][] { new byte[] { 68, 69, 66, 85, 71 }, new byte[] { 79, 66, 74, 69, 67, 84 } };
            mapping[RedisCommands.DEBUGSEGFAULT] = new byte[][] { new byte[] { 68, 69, 66, 85, 71 }, new byte[] { 83, 69, 71, 70, 65, 85, 76, 84 } };
            mapping[RedisCommands.DECR] = new byte[][] { new byte[] { 68, 69, 67, 82 } };
            mapping[RedisCommands.DECRBY] = new byte[][] { new byte[] { 68, 69, 67, 82, 66, 89 } };
            mapping[RedisCommands.DEL] = new byte[][] { new byte[] { 68, 69, 76 } };
            mapping[RedisCommands.DISCARD] = new byte[][] { new byte[] { 68, 73, 83, 67, 65, 82, 68 } };
            mapping[RedisCommands.DUMP] = new byte[][] { new byte[] { 68, 85, 77, 80 } };
            mapping[RedisCommands.ECHO] = new byte[][] { new byte[] { 69, 67, 72, 79 } };
            mapping[RedisCommands.EVAL] = new byte[][] { new byte[] { 69, 86, 65, 76 } };
            mapping[RedisCommands.EVALSHA] = new byte[][] { new byte[] { 69, 86, 65, 76, 83, 72, 65 } };
            mapping[RedisCommands.EXEC] = new byte[][] { new byte[] { 69, 88, 69, 67 } };
            mapping[RedisCommands.EXISTS] = new byte[][] { new byte[] { 69, 88, 73, 83, 84, 83 } };
            mapping[RedisCommands.EXPIRE] = new byte[][] { new byte[] { 69, 88, 80, 73, 82, 69 } };
            mapping[RedisCommands.EXPIREAT] = new byte[][] { new byte[] { 69, 88, 80, 73, 82, 69, 65, 84 } };
            mapping[RedisCommands.FLUSHALL] = new byte[][] { new byte[] { 70, 76, 85, 83, 72, 65, 76, 76 } };
            mapping[RedisCommands.FLUSHDB] = new byte[][] { new byte[] { 70, 76, 85, 83, 72, 68, 66 } };
            mapping[RedisCommands.GET] = new byte[][] { new byte[] { 71, 69, 84 } };
            mapping[RedisCommands.GETBIT] = new byte[][] { new byte[] { 71, 69, 84, 66, 73, 84 } };
            mapping[RedisCommands.GETRANGE] = new byte[][] { new byte[] { 71, 69, 84, 82, 65, 78, 71, 69 } };
            mapping[RedisCommands.GETSET] = new byte[][] { new byte[] { 71, 69, 84, 83, 69, 84 } };
            mapping[RedisCommands.HDEL] = new byte[][] { new byte[] { 72, 68, 69, 76 } };
            mapping[RedisCommands.HEXISTS] = new byte[][] { new byte[] { 72, 69, 88, 73, 83, 84, 83 } };
            mapping[RedisCommands.HGET] = new byte[][] { new byte[] { 72, 71, 69, 84 } };
            mapping[RedisCommands.HGETALL] = new byte[][] { new byte[] { 72, 71, 69, 84, 65, 76, 76 } };
            mapping[RedisCommands.HINCRBY] = new byte[][] { new byte[] { 72, 73, 78, 67, 82, 66, 89 } };
            mapping[RedisCommands.HINCRBYFLOAT] = new byte[][] { new byte[] { 72, 73, 78, 67, 82, 66, 89, 70, 76, 79, 65, 84 } };
            mapping[RedisCommands.HKEYS] = new byte[][] { new byte[] { 72, 75, 69, 89, 83 } };
            mapping[RedisCommands.HLEN] = new byte[][] { new byte[] { 72, 76, 69, 78 } };
            mapping[RedisCommands.HMGET] = new byte[][] { new byte[] { 72, 77, 71, 69, 84 } };
            mapping[RedisCommands.HMSET] = new byte[][] { new byte[] { 72, 77, 83, 69, 84 } };
            mapping[RedisCommands.HSET] = new byte[][] { new byte[] { 72, 83, 69, 84 } };
            mapping[RedisCommands.HSETNX] = new byte[][] { new byte[] { 72, 83, 69, 84, 78, 88 } };
            mapping[RedisCommands.HVALS] = new byte[][] { new byte[] { 72, 86, 65, 76, 83 } };
            mapping[RedisCommands.INCR] = new byte[][] { new byte[] { 73, 78, 67, 82 } };
            mapping[RedisCommands.INCRBY] = new byte[][] { new byte[] { 73, 78, 67, 82, 66, 89 } };
            mapping[RedisCommands.INCRBYFLOAT] = new byte[][] { new byte[] { 73, 78, 67, 82, 66, 89, 70, 76, 79, 65, 84 } };
            mapping[RedisCommands.INFO] = new byte[][] { new byte[] { 73, 78, 70, 79 } };
            mapping[RedisCommands.KEYS] = new byte[][] { new byte[] { 75, 69, 89, 83 } };
            mapping[RedisCommands.LASTSAVE] = new byte[][] { new byte[] { 76, 65, 83, 84, 83, 65, 86, 69 } };
            mapping[RedisCommands.LINDEX] = new byte[][] { new byte[] { 76, 73, 78, 68, 69, 88 } };
            mapping[RedisCommands.LINSERT] = new byte[][] { new byte[] { 76, 73, 78, 83, 69, 82, 84 } };
            mapping[RedisCommands.LLEN] = new byte[][] { new byte[] { 76, 76, 69, 78 } };
            mapping[RedisCommands.LPOP] = new byte[][] { new byte[] { 76, 80, 79, 80 } };
            mapping[RedisCommands.LPUSH] = new byte[][] { new byte[] { 76, 80, 85, 83, 72 } };
            mapping[RedisCommands.LPUSHX] = new byte[][] { new byte[] { 76, 80, 85, 83, 72, 88 } };
            mapping[RedisCommands.LRANGE] = new byte[][] { new byte[] { 76, 82, 65, 78, 71, 69 } };
            mapping[RedisCommands.LREM] = new byte[][] { new byte[] { 76, 82, 69, 77 } };
            mapping[RedisCommands.LSET] = new byte[][] { new byte[] { 76, 83, 69, 84 } };
            mapping[RedisCommands.LTRIM] = new byte[][] { new byte[] { 76, 84, 82, 73, 77 } };
            mapping[RedisCommands.MGET] = new byte[][] { new byte[] { 77, 71, 69, 84 } };
            mapping[RedisCommands.MIGRATE] = new byte[][] { new byte[] { 77, 73, 71, 82, 65, 84, 69 } };
            mapping[RedisCommands.MONITOR] = new byte[][] { new byte[] { 77, 79, 78, 73, 84, 79, 82 } };
            mapping[RedisCommands.MOVE] = new byte[][] { new byte[] { 77, 79, 86, 69 } };
            mapping[RedisCommands.MSET] = new byte[][] { new byte[] { 77, 83, 69, 84 } };
            mapping[RedisCommands.MSETNX] = new byte[][] { new byte[] { 77, 83, 69, 84, 78, 88 } };
            mapping[RedisCommands.MULTI] = new byte[][] { new byte[] { 77, 85, 76, 84, 73 } };
            mapping[RedisCommands.OBJECT] = new byte[][] { new byte[] { 79, 66, 74, 69, 67, 84 } };
            mapping[RedisCommands.PERSIST] = new byte[][] { new byte[] { 80, 69, 82, 83, 73, 83, 84 } };
            mapping[RedisCommands.PEXPIRE] = new byte[][] { new byte[] { 80, 69, 88, 80, 73, 82, 69 } };
            mapping[RedisCommands.PEXPIREAT] = new byte[][] { new byte[] { 80, 69, 88, 80, 73, 82, 69, 65, 84 } };
            mapping[RedisCommands.PFADD] = new byte[][] { new byte[] { 80, 70, 65, 68, 68 } };
            mapping[RedisCommands.PFCOUNT] = new byte[][] { new byte[] { 80, 70, 67, 79, 85, 78, 84 } };
            mapping[RedisCommands.PFMERGE] = new byte[][] { new byte[] { 80, 70, 77, 69, 82, 71, 69 } };
            mapping[RedisCommands.PING] = new byte[][] { new byte[] { 80, 73, 78, 71 } };
            mapping[RedisCommands.PSETEX] = new byte[][] { new byte[] { 80, 83, 69, 84, 69, 88 } };
            mapping[RedisCommands.PSUBSCRIBE] = new byte[][] { new byte[] { 80, 83, 85, 66, 83, 67, 82, 73, 66, 69 } };
            mapping[RedisCommands.PUBSUB] = new byte[][] { new byte[] { 80, 85, 66, 83, 85, 66 } };
            mapping[RedisCommands.PTTL] = new byte[][] { new byte[] { 80, 84, 84, 76 } };
            mapping[RedisCommands.PUBLISH] = new byte[][] { new byte[] { 80, 85, 66, 76, 73, 83, 72 } };
            mapping[RedisCommands.PUNSUBSCRIBE] = new byte[][] { new byte[] { 80, 85, 78, 83, 85, 66, 83, 67, 82, 73, 66, 69 } };
            mapping[RedisCommands.QUIT] = new byte[][] { new byte[] { 81, 85, 73, 84 } };
            mapping[RedisCommands.RANDOMKEY] = new byte[][] { new byte[] { 82, 65, 78, 68, 79, 77, 75, 69, 89 } };
            mapping[RedisCommands.RENAME] = new byte[][] { new byte[] { 82, 69, 78, 65, 77, 69 } };
            mapping[RedisCommands.RENAMENX] = new byte[][] { new byte[] { 82, 69, 78, 65, 77, 69, 78, 88 } };
            mapping[RedisCommands.RESTORE] = new byte[][] { new byte[] { 82, 69, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.RPOP] = new byte[][] { new byte[] { 82, 80, 79, 80 } };
            mapping[RedisCommands.RPOPLPUSH] = new byte[][] { new byte[] { 82, 80, 79, 80, 76, 80, 85, 83, 72 } };
            mapping[RedisCommands.RPUSH] = new byte[][] { new byte[] { 82, 80, 85, 83, 72 } };
            mapping[RedisCommands.RPUSHX] = new byte[][] { new byte[] { 82, 80, 85, 83, 72, 88 } };
            mapping[RedisCommands.SADD] = new byte[][] { new byte[] { 83, 65, 68, 68 } };
            mapping[RedisCommands.SAVE] = new byte[][] { new byte[] { 83, 65, 86, 69 } };
            mapping[RedisCommands.SCARD] = new byte[][] { new byte[] { 83, 67, 65, 82, 68 } };
            mapping[RedisCommands.SCRIPTEXISTS] = new byte[][] { new byte[] { 83, 67, 82, 73, 80, 84 }, new byte[] { 69, 88, 73, 83, 84, 83 } };
            mapping[RedisCommands.SCRIPTFLUSH] = new byte[][] { new byte[] { 83, 67, 82, 73, 80, 84 }, new byte[] { 70, 76, 85, 83, 72 } };
            mapping[RedisCommands.SCRIPTKILL] = new byte[][] { new byte[] { 83, 67, 82, 73, 80, 84 }, new byte[] { 75, 73, 76, 76 } };
            mapping[RedisCommands.SCRIPTLOAD] = new byte[][] { new byte[] { 83, 67, 82, 73, 80, 84 }, new byte[] { 76, 79, 65, 68 } };
            mapping[RedisCommands.SDIFF] = new byte[][] { new byte[] { 83, 68, 73, 70, 70 } };
            mapping[RedisCommands.SDIFFSTORE] = new byte[][] { new byte[] { 83, 68, 73, 70, 70, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.SELECT] = new byte[][] { new byte[] { 83, 69, 76, 69, 67, 84 } };
            mapping[RedisCommands.SET] = new byte[][] { new byte[] { 83, 69, 84 } };
            mapping[RedisCommands.SETBIT] = new byte[][] { new byte[] { 83, 69, 84, 66, 73, 84 } };
            mapping[RedisCommands.SETEX] = new byte[][] { new byte[] { 83, 69, 84, 69, 88 } };
            mapping[RedisCommands.SETNX] = new byte[][] { new byte[] { 83, 69, 84, 78, 88 } };
            mapping[RedisCommands.SETRANGE] = new byte[][] { new byte[] { 83, 69, 84, 82, 65, 78, 71, 69 } };
            mapping[RedisCommands.SHUTDOWN] = new byte[][] { new byte[] { 83, 72, 85, 84, 68, 79, 87, 78 } };
            mapping[RedisCommands.SINTER] = new byte[][] { new byte[] { 83, 73, 78, 84, 69, 82 } };
            mapping[RedisCommands.SINTERSTORE] = new byte[][] { new byte[] { 83, 73, 78, 84, 69, 82, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.SISMEMBER] = new byte[][] { new byte[] { 83, 73, 83, 77, 69, 77, 66, 69, 82 } };
            mapping[RedisCommands.SLAVEOF] = new byte[][] { new byte[] { 83, 76, 65, 86, 69, 79, 70 } };
            mapping[RedisCommands.SLOWLOG] = new byte[][] { new byte[] { 83, 76, 79, 87, 76, 79, 71 } };
            mapping[RedisCommands.SMEMBERS] = new byte[][] { new byte[] { 83, 77, 69, 77, 66, 69, 82, 83 } };
            mapping[RedisCommands.SMOVE] = new byte[][] { new byte[] { 83, 77, 79, 86, 69 } };
            mapping[RedisCommands.SORT] = new byte[][] { new byte[] { 83, 79, 82, 84 } };
            mapping[RedisCommands.SPOP] = new byte[][] { new byte[] { 83, 80, 79, 80 } };
            mapping[RedisCommands.SRANDMEMBER] = new byte[][] { new byte[] { 83, 82, 65, 78, 68, 77, 69, 77, 66, 69, 82 } };
            mapping[RedisCommands.SREM] = new byte[][] { new byte[] { 83, 82, 69, 77 } };
            mapping[RedisCommands.STRLEN] = new byte[][] { new byte[] { 83, 84, 82, 76, 69, 78 } };
            mapping[RedisCommands.SUBSCRIBE] = new byte[][] { new byte[] { 83, 85, 66, 83, 67, 82, 73, 66, 69 } };
            mapping[RedisCommands.SUNION] = new byte[][] { new byte[] { 83, 85, 78, 73, 79, 78 } };
            mapping[RedisCommands.SUNIONSTORE] = new byte[][] { new byte[] { 83, 85, 78, 73, 79, 78, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.SYNC] = new byte[][] { new byte[] { 83, 89, 78, 67 } };
            mapping[RedisCommands.TIME] = new byte[][] { new byte[] { 84, 73, 77, 69 } };
            mapping[RedisCommands.TTL] = new byte[][] { new byte[] { 84, 84, 76 } };
            mapping[RedisCommands.TYPE] = new byte[][] { new byte[] { 84, 89, 80, 69 } };
            mapping[RedisCommands.UNSUBSCRIBE] = new byte[][] { new byte[] { 85, 78, 83, 85, 66, 83, 67, 82, 73, 66, 69 } };
            mapping[RedisCommands.UNWATCH] = new byte[][] { new byte[] { 85, 78, 87, 65, 84, 67, 72 } };
            mapping[RedisCommands.WATCH] = new byte[][] { new byte[] { 87, 65, 84, 67, 72 } };
            mapping[RedisCommands.ZADD] = new byte[][] { new byte[] { 90, 65, 68, 68 } };
            mapping[RedisCommands.ZCARD] = new byte[][] { new byte[] { 90, 67, 65, 82, 68 } };
            mapping[RedisCommands.ZCOUNT] = new byte[][] { new byte[] { 90, 67, 79, 85, 78, 84 } };
            mapping[RedisCommands.ZINCRBY] = new byte[][] { new byte[] { 90, 73, 78, 67, 82, 66, 89 } };
            mapping[RedisCommands.ZINTERSTORE] = new byte[][] { new byte[] { 90, 73, 78, 84, 69, 82, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.ZLEXCOUNT] = new byte[][] { new byte[] { 90, 76, 69, 88, 67, 79, 85, 78, 84 } };
            mapping[RedisCommands.ZRANGE] = new byte[][] { new byte[] { 90, 82, 65, 78, 71, 69 } };
            mapping[RedisCommands.ZRANGEBYLEX] = new byte[][] { new byte[] { 90, 82, 65, 78, 71, 69, 66, 89, 76, 69, 88 } };
            mapping[RedisCommands.ZRANGEBYSCORE] = new byte[][] { new byte[] { 90, 82, 65, 78, 71, 69, 66, 89, 83, 67, 79, 82, 69 } };
            mapping[RedisCommands.ZRANK] = new byte[][] { new byte[] { 90, 82, 65, 78, 75 } };
            mapping[RedisCommands.ZREM] = new byte[][] { new byte[] { 90, 82, 69, 77 } };
            mapping[RedisCommands.ZREMRANGEBYLEX] = new byte[][] { new byte[] { 90, 82, 69, 77, 82, 65, 78, 71, 69, 66, 89, 76, 69, 88 } };
            mapping[RedisCommands.ZREMRANGEBYRANK] = new byte[][] { new byte[] { 90, 82, 69, 77, 82, 65, 78, 71, 69, 66, 89, 82, 65, 78, 75 } };
            mapping[RedisCommands.ZREMRANGEBYSCORE] = new byte[][] { new byte[] { 90, 82, 69, 77, 82, 65, 78, 71, 69, 66, 89, 83, 67, 79, 82, 69 } };
            mapping[RedisCommands.ZREVRANGE] = new byte[][] { new byte[] { 90, 82, 69, 86, 82, 65, 78, 71, 69 } };
            mapping[RedisCommands.ZREVRANGEBYSCORE] = new byte[][] { new byte[] { 90, 82, 69, 86, 82, 65, 78, 71, 69, 66, 89, 83, 67, 79, 82, 69 } };
            mapping[RedisCommands.ZREVRANK] = new byte[][] { new byte[] { 90, 82, 69, 86, 82, 65, 78, 75 } };
            mapping[RedisCommands.ZSCORE] = new byte[][] { new byte[] { 90, 83, 67, 79, 82, 69 } };
            mapping[RedisCommands.ZUNIONSTORE] = new byte[][] { new byte[] { 90, 85, 78, 73, 79, 78, 83, 84, 79, 82, 69 } };
            mapping[RedisCommands.SCAN] = new byte[][] { new byte[] { 83, 67, 65, 78 } };
            mapping[RedisCommands.SSCAN] = new byte[][] { new byte[] { 83, 83, 67, 65, 78 } };
            mapping[RedisCommands.HSCAN] = new byte[][] { new byte[] { 72, 83, 67, 65, 78 } };
            mapping[RedisCommands.ZSCAN] = new byte[][] { new byte[] { 90, 83, 67, 65, 78 } };
        }

        internal static bool IsValidCommand(string command)
        {
            return mapping.ContainsKey(command);
        }

        internal static RedisCommand GenerateCommand(string command)
        {
            byte[][] arguments;
            if (!mapping.TryGetValue(command, out arguments))
                throw new ArgumentOutOfRangeException("command");

            return new RedisCommand(arguments);
        }
    }
}
