
namespace Simple.Redis
{
    public static class RedisCommands
    {
        /// <summary>
        /// [STRINGS] append a value to a key
        /// </summary>
        public const string APPEND = "APPEND";

        /// <summary>
        /// [CONNECTION] authenticate to the server
        /// </summary>
        public const string AUTH = "AUTH";

        /// <summary>
        /// [SERVER] asynchronously rewrite the append-only file
        /// </summary>
        public const string BGREWRITEAOF = "BGREWRITEAOF";

        /// <summary>
        /// [SERVER] asynchronously save the dataset to disk
        /// </summary>
        public const string BGSAVE = "BGSAVE";

        /// <summary>
        /// [STRINGS] count set bits in a string
        /// </summary>
        public const string BITCOUNT = "BITCOUNT";

        /// <summary>
        /// [STRINGS] perform bitwise operations between strings
        /// </summary>
        public const string BITOP = "BITOP";

        /// <summary>
        /// [STRINGS] find first bit set or clear in a string
        /// </summary>
        public const string BITPOS = "BITPOS";

        /// <summary>
        /// [LISTS] remove and get the first element in a list, or block until one is available
        /// </summary>
        public const string BLPOP = "BLPOP";

        /// <summary>
        /// [LISTS] remove and get the last element in a list, or block until one is available
        /// </summary>
        public const string BRPOP = "BRPOP";

        /// <summary>
        /// [LISTS] pop a value from a list, push it to another list and return it; or block until one is available
        /// </summary>
        public const string BRPOPLPUSH = "BRPOPLPUSH";

        /// <summary>
        /// [SERVER] kill the connection of a client
        /// </summary>
        public const string CLIENTKILL = "CLIENT KILL";

        /// <summary>
        /// [SERVER] get the list of client connections
        /// </summary>
        public const string CLIENTLIST = "CLIENT LIST";

        /// <summary>
        /// [SERVER] get the current connection name
        /// </summary>
        public const string CLIENTGETNAME = "CLIENT GETNAME";

        /// <summary>
        /// [SERVER] stop processing commands from clients for some given time
        /// </summary>
        public const string CLIENTPAUSE = "CLIENT PAUSE";

        /// <summary>
        /// [SERVER] set the current connection name
        /// </summary>
        public const string CLIENTSETNAME = "CLIENT SETNAME";

        /// <summary>
        /// [SERVER] get the value of a configuration parameter
        /// </summary>
        public const string CONFIGGET = "CONFIG GET";

        /// <summary>
        /// [SERVER] rewrite the configuration file with the in memory configuration
        /// </summary>
        public const string CONFIGREWRITE = "CONFIG REWRITE";

        /// <summary>
        /// [SERVER] set a configuration parameter to the given value
        /// </summary>
        public const string CONFIGSET = "CONFIG SET";

        /// <summary>
        /// [SERVER] reset the stats returned by <see cref="INFO"/>
        /// </summary>
        public const string CONFIGRESETSTAT = "CONFIG RESETSTAT";

        /// <summary>
        /// [SERVER] return the number of keys in the selected keyspace
        /// </summary>
        public const string DBSIZE = "DBSIZE";

        /// <summary>
        /// [SERVER] get debugging information about a key
        /// </summary>
        public const string DEBUGOBJECT = "DEBUG OBJECT";

        /// <summary>
        /// [SERVER] make the server crash
        /// </summary>
        public const string DEBUGSEGFAULT = "DEBUG SEGFAULT";

        /// <summary>
        /// [STRINGS] decrement the integer value of a key by one (1)
        /// </summary>
        public const string DECR = "DECR";

        /// <summary>
        /// [STRINGS] decrement the integer value of a key by the given number
        /// </summary>
        public const string DECRBY = "DECRBY";

        /// <summary>
        /// [KEY] delete a key 
        /// </summary>
        public const string DEL = "DEL";

        /// <summary>
        /// [TRANSACTION] discard all commands issued after <see cref="MULTI"/>
        /// </summary>
        public const string DISCARD = "DISCARD";

        /// <summary>
        /// [KEY] return a serialized version of the value stored at the specified key
        /// </summary>
        public const string DUMP = "DUMP";

        /// <summary>
        /// [CONNECTION] echo the given string
        /// </summary>
        public const string ECHO = "ECHO";

        /// <summary>
        /// [SCRIPT] execute a Lua script server side
        /// </summary>
        public const string EVAL = "EVAL";

        /// <summary>
        /// [SCRIPT] execute a Lua script server side
        /// </summary>
        public const string EVALSHA = "EVALSHA";

        /// <summary>
        /// [TRANSACTION] execute all commands issued after <see cref="MULTI"/>
        /// </summary>
        public const string EXEC = "EXEC";

        /// <summary>
        /// [KEY] determines if the key exists
        /// </summary>
        public const string EXISTS = "EXISTS";

        /// <summary>
        /// [KEY] set a key's time to live in seconds
        /// </summary>
        public const string EXPIRE = "EXPIRE";

        /// <summary>
        /// [KEY] set the expiration for a key as a UNIX timestamp
        /// </summary>
        public const string EXPIREAT = "EXPIREAT";

        /// <summary>
        /// [SERVER] remove all keys from all keyspaces
        /// </summary>
        public const string FLUSHALL = "FLUSHALL";

        /// <summary>
        /// [SERVER] remove all keys from current keyspace
        /// </summary>
        public const string FLUSHDB = "FLUSHDB";

        /// <summary>
        /// [STRINGS] get the value of a key
        /// </summary>
        public const string GET = "GET";

        /// <summary>
        /// [STRINGS] returns the bit value at offset in the string value stored at key
        /// </summary>
        public const string GETBIT = "GETBIT";

        /// <summary>
        /// [STRINGS] get a substring of the string stored at a key
        /// </summary>
        public const string GETRANGE = "GETRANGE";

        /// <summary>
        /// [STRINGS] set the string value of a key and return its old value
        /// </summary>
        public const string GETSET = "GETSET";

        /// <summary>
        /// [HASHES] delete one or more hash fields
        /// </summary>
        public const string HDEL = "HDEL";

        /// <summary>
        /// [HASHES] determine if a hash field exists
        /// </summary>
        public const string HEXISTS = "HEXISTS";

        /// <summary>
        /// [HASHES] get the value of a hash field
        /// </summary>
        public const string HGET = "HGET";

        /// <summary>
        /// [HASHES] get all the fields and values in a hash
        /// </summary>
        public const string HGETALL = "HGETALL";

        /// <summary>
        /// [HASHES] increment the integer value of a hash field by the given number
        /// </summary>
        public const string HINCRBY = "HINCRBY";

        /// <summary>
        /// [HASHES] increment the float value of a hash field by the given amount
        /// </summary>
        public const string HINCRBYFLOAT = "HINCRBYFLOAT";

        /// <summary>
        /// [HASHES] get all the fields in a hash
        /// </summary>
        public const string HKEYS = "HKEYS";

        /// <summary>
        /// [HASHES] get the number of fields in a hash
        /// </summary>
        public const string HLEN = "HLEN";

        /// <summary>
        /// [HASHES] get the values of all the given hash fields
        /// </summary>
        public const string HMGET = "HMGET";

        /// <summary>
        /// [HASHES] set multiple hash fields to multiple values
        /// </summary>
        public const string HMSET = "HMSET";

        /// <summary>
        /// [HASHES] set the string value of a hash field
        /// </summary>
        public const string HSET = "HSET";

        /// <summary>
        /// [HASHES] set the value of a hash field, only if the field does not exist
        /// </summary>
        public const string HSETNX = "HSETNX";

        /// <summary>
        /// [HASHES] get all the values in a hash
        /// </summary>
        public const string HVALS = "HVALS";

        /// <summary>
        /// [STRINGS] increment the integer value of a key by one (1)
        /// </summary>
        public const string INCR = "INCR";

        /// <summary>
        /// [STRINGS] increment the integer value of a key by the given number
        /// </summary>
        public const string INCRBY = "INCRBY";

        /// <summary>
        /// [STRINGS] increment the float value of a key by the given amount
        /// </summary>
        public const string INCRBYFLOAT = "INCRBYFLOAT";

        /// <summary>
        /// [SERVER] get information and statistics about the server
        /// </summary>
        public const string INFO = "INFO";

        /// <summary>
        /// [KEY] find all keys matching the given pattern
        /// </summary>
        public const string KEYS = "KEYS";

        /// <summary>
        /// [SERVER] get the UNIX timestamp of the last successful save to disk
        /// </summary>
        public const string LASTSAVE = "LASTSAVE";

        /// <summary>
        /// [LISTS] get an element from a list by its index
        /// </summary>
        public const string LINDEX = "LINDEX";

        /// <summary>
        /// [LISTS] insert an element before or after another element in a list
        /// </summary>
        public const string LINSERT = "LINSERT";

        /// <summary>
        /// [LISTS] get the length of a list
        /// </summary>
        public const string LLEN = "LLEN";

        /// <summary>
        /// [LISTS] remove and get the first element in a list
        /// </summary>
        public const string LPOP = "LPOP";

        /// <summary>
        /// [LISTS] prepend one or multiple values to a list
        /// </summary>
        public const string LPUSH = "LPUSH";

        /// <summary>
        /// [LISTS] prepend a value to a list, only if the list exists
        /// </summary>
        public const string LPUSHX = "LPUSHX";

        /// <summary>
        /// [LISTS] get a range of elements from a list
        /// </summary>
        public const string LRANGE = "LRANGE";

        /// <summary>
        /// [LISTS] remove elements from a list
        /// </summary>
        public const string LREM = "LREM";

        /// <summary>
        /// [LISTS] set the value of an element in a list by its index
        /// </summary>
        public const string LSET = "LSET";

        /// <summary>
        /// [LISTS] trim a list to the specified range
        /// </summary>
        public const string LTRIM = "LTRIM";

        /// <summary>
        /// [STRINGS] get the values of all the given keys
        /// </summary>
        public const string MGET = "MGET";

        /// <summary>
        /// [KEY] automatically transfer a key from one Redis instance to another
        /// </summary>
        public const string MIGRATE = "MIGRATE";

        /// <summary>
        /// [SERVER] listen for all requests received by the server in real time
        /// </summary>
        public const string MONITOR = "MONITOR";

        /// <summary>
        /// [KEY] move a key to another keyspace
        /// </summary>
        public const string MOVE = "MOVE";

        /// <summary>
        /// [STRINGS] set multiple keys to multiple values
        /// </summary>
        public const string MSET = "MSET";

        /// <summary>
        /// [STRINGS] set multiple keys to multiple values, only if none of the keys exist
        /// </summary>
        public const string MSETNX = "MSETNX";

        /// <summary>
        /// [TRANSACTION] mark the start of a transaction block
        /// </summary>
        public const string MULTI = "MULTI";

        /// <summary>
        /// [KEY] inspect the internals of Redis objects
        /// </summary>
        public const string OBJECT = "OBJECT";

        /// <summary>
        /// [KEY] remove the expiration from a key
        /// </summary>
        public const string PERSIST = "PERSIST";

        /// <summary>
        /// [KEY] set a key's time to live in milliseconds
        /// </summary>
        public const string PEXPIRE = "PEXPIRE";

        /// <summary>
        /// [KEY] set the expiration for a key as a UNIX timestamp specified in milliseconds
        /// </summary>
        public const string PEXPIREAT = "PEXPIREAT";

        /// <summary>
        /// [HYPERLOGLOG] adds the specified elements to the specified HyperLogLog
        /// </summary>
        public const string PFADD = "PFADD";

        /// <summary>
        /// [HYPERLOGLOG] return the approximated cardinality of the set(s) observed by the HyperLogLog at key(s)
        /// </summary>
        public const string PFCOUNT = "PFCOUNT";

        /// <summary>
        /// [HYPERLOGLOG] merge N different HyperLogLogs into a single one
        /// </summary>
        public const string PFMERGE = "PFMERGE";

        /// <summary>
        /// [CONNECTION] ping the server
        /// </summary>
        public const string PING = "PING";

        /// <summary>
        /// [STRINGS] set the value and expiration in milliseconds of a key
        /// </summary>
        public const string PSETEX = "PSETEX";

        /// <summary>
        /// [PUBSUB] listen for messages published to channels matching the given patterns
        /// </summary>
        public const string PSUBSCRIBE = "PSUBSCRIBE";

        /// <summary>
        /// [PUBSUB] inspect the state of the Pub/Sub subsystem
        /// </summary>
        public const string PUBSUB = "PUBSUB";

        /// <summary>
        /// [KEY] get the time to live for a key in milliseconds
        /// </summary>
        public const string PTTL = "PTTL";

        /// <summary>
        /// [PUBSUB] post a message to a channel
        /// </summary>
        public const string PUBLISH = "PUBLISH";

        /// <summary>
        /// [PUBSUB] stop listening for messages posted to channels matching the given patterns
        /// </summary>
        public const string PUNSUBSCRIBE = "PUNSUBSCRIBE";

        /// <summary>
        /// [CONNECTION] close the connection
        /// </summary>
        public const string QUIT = "QUIT";

        /// <summary>
        /// [KEY] return a random key from the keyspace
        /// </summary>
        public const string RANDOMKEY = "RANDOMKEY";

        /// <summary>
        /// [KEY] rename a key
        /// </summary>
        public const string RENAME = "RENAME";

        /// <summary>
        /// [KEY] rename a key, only if the new key does not exist
        /// </summary>
        public const string RENAMENX = "RENAMENX";

        /// <summary>
        /// [KEY] create a key using the provided serialized value, previously obtained using <see cref="DUMP"/>
        /// </summary>
        public const string RESTORE = "RESTORE";

        /// <summary>
        /// [LISTS] remove and get the last element in a list
        /// </summary>
        public const string RPOP = "RPOP";

        /// <summary>
        /// [LISTS] remove the last element in a list, append it to another list and return it
        /// </summary>
        public const string RPOPLPUSH = "RPOPLPUSH";

        /// <summary>
        /// [LISTS] append one or multiple values to a lit
        /// </summary>
        public const string RPUSH = "RPUSH";

        /// <summary>
        /// [LISTS] append a value to a list, only if the list exists
        /// </summary>
        public const string RPUSHX = "RPUSHX";

        /// <summary>
        /// [SETS] add one or more members to a set
        /// </summary>
        public const string SADD = "SADD";

        /// <summary>
        /// [SERVER] synchronously save the dataset to disk
        /// </summary>
        public const string SAVE = "SAVE";

        /// <summary>
        /// [SETS] get the number of members in a set
        /// </summary>
        public const string SCARD = "SCARD";

        /// <summary>
        /// [SCRIPT] check existence of scripts in the script cache
        /// </summary>
        public const string SCRIPTEXISTS = "SCRIPT EXISTS";

        /// <summary>
        /// [SCRIPT] remove all the scripts from the script cache
        /// </summary>
        public const string SCRIPTFLUSH = "SCRIPT FLUSH";

        /// <summary>
        /// [SCRIPT] kill the script currently in execution
        /// </summary>
        public const string SCRIPTKILL = "SCRIPT KILL";

        /// <summary>
        /// [SCRIPT] load the specified Lua script into the script cache
        /// </summary>
        public const string SCRIPTLOAD = "SCRIPT LOAD";

        /// <summary>
        /// [SETS] subtract multiple sets
        /// </summary>
        public const string SDIFF = "SDIFF";

        /// <summary>
        /// [SETS] subtract multiple sets and store the resulting set in a key
        /// </summary>
        public const string SDIFFSTORE = "SDIFFSTORE";

        /// <summary>
        /// [CONNECTION] change the selected keystore for the current connection
        /// </summary>
        public const string SELECT = "SELECT";

        /// <summary>
        /// [STRINGS] set the string value of a key
        /// </summary>
        public const string SET = "SET";

        /// <summary>
        /// [STRINGS] sets or clears the bit at offset in the string value stored at key
        /// </summary>
        public const string SETBIT = "SETBIT";

        /// <summary>
        /// [STRINGS] set the value and expiration of a key
        /// </summary>
        public const string SETEX = "SETEX";

        /// <summary>
        /// [STRINGS] set the value of a key, only if the key does not exist
        /// </summary>
        public const string SETNX = "SETNX";

        /// <summary>
        /// [STRINGS] overwrite part of a string at key starting at the specified offset
        /// </summary>
        public const string SETRANGE = "SETRANGE";

        /// <summary>
        /// [SERVER] synchronously save the dataset to disk and then shut down the server
        /// </summary>
        public const string SHUTDOWN = "SHUTDOWN";

        /// <summary>
        /// [SETS] intersect multiple sets
        /// </summary>
        public const string SINTER = "SINTER";

        /// <summary>
        /// [SETS] intersect multiple sets and store the resulting set in a key
        /// </summary>
        public const string SINTERSTORE = "SINTERSTORE";

        /// <summary>
        /// [SETS] determine if a given value is a member of a set
        /// </summary>
        public const string SISMEMBER = "SISMEMBER";

        /// <summary>
        /// [SERVER] make the server a slave of another instance, or promote it as master
        /// </summary>
        public const string SLAVEOF = "SLAVEOF";

        /// <summary>
        /// [SERVER] manages the Redis slow queries log
        /// </summary>
        public const string SLOWLOG = "SLOWLOG";

        /// <summary>
        /// [SETS] get all the members in a set
        /// </summary>
        public const string SMEMBERS = "SMEMBERS";

        /// <summary>
        /// [SETS] move a member from one set to another
        /// </summary>
        public const string SMOVE = "SMOVE";

        /// <summary>
        /// [KEY] sort the elements in a list, set or sorted set
        /// </summary>
        public const string SORT = "SORT";

        /// <summary>
        /// [SETS] remove and return a random member from a set
        /// </summary>
        public const string SPOP = "SPOP";

        /// <summary>
        /// [SETS] get one or multiple random members from a set
        /// </summary>
        public const string SRANDMEMBER = "SRANDMEMBER";

        /// <summary>
        /// [SETS] remove one or more members from a set
        /// </summary>
        public const string SREM = "SREM";

        /// <summary>
        /// [STRINGS] get the length of the value stored in a key
        /// </summary>
        public const string STRLEN = "STRLEN";

        /// <summary>
        /// [PUBSUB] listen for messages published to the given channels
        /// </summary>
        public const string SUBSCRIBE = "SUBSCRIBE";

        /// <summary>
        /// [SETS] add multiple sets
        /// </summary>
        public const string SUNION = "SUNION";

        /// <summary>
        /// [SETS] add multiple sets and store the resulting set in a key
        /// </summary>
        public const string SUNIONSTORE = "SUNIONSTORE";

        /// <summary>
        /// [SERVER] internal command used for replication
        /// </summary>
        public const string SYNC = "SYNC";

        /// <summary>
        /// [SERVER] return the current server time
        /// </summary>
        public const string TIME = "TIME";

        /// <summary>
        /// [KEY] get the time to live for a key
        /// </summary>
        public const string TTL = "TTL";

        /// <summary>
        /// [KEY] determine the type stored at a key
        /// </summary>
        public const string TYPE = "TYPE";

        /// <summary>
        /// [PUBSUB] stop listening for messages posted to the given channels
        /// </summary>
        public const string UNSUBSCRIBE = "UNSUBSCRIBE";

        /// <summary>
        /// [TRANSACTION] forget about all watched keys
        /// </summary>
        public const string UNWATCH = "UNWATCH";

        /// <summary>
        /// [TRANSACTION] watch the given keys to determine execution of the <see cref="MULTI"/>/<see cref="EXEC"/> block
        /// </summary>
        public const string WATCH = "WATCH";

        /// <summary>
        /// [SORTEDSETS] add one or more members to a sorted set, or update its score if it already exists
        /// </summary>
        public const string ZADD = "ZADD";

        /// <summary>
        /// [SORTEDSETS] get the number of members in a sorted set
        /// </summary>
        public const string ZCARD = "ZCARD";

        /// <summary>
        /// [SORTEDSETS] count the members in a sorted set with scores within the given values
        /// </summary>
        public const string ZCOUNT = "ZCOUNT";

        /// <summary>
        /// [SORTEDSETS] increment the score of a member in a sorted set
        /// </summary>
        public const string ZINCRBY = "ZINCRBY";

        /// <summary>
        /// [SORTEDSETS] intersect multiple sorted sets and store the resulting sorted set in a new key
        /// </summary>
        public const string ZINTERSTORE = "ZINTERSTORE";

        /// <summary>
        /// [SORTEDSETS] count the number of members in a sorted set between a given lexicographical range
        /// </summary>
        public const string ZLEXCOUNT = "ZLEXCOUNT";

        /// <summary>
        /// [SORTEDSETS] return a range of members in a sorted set, by index
        /// </summary>
        public const string ZRANGE = "ZRANGE";

        /// <summary>
        /// [SORTEDSETS] return a range of members in a sorted set, by lexicographical range
        /// </summary>
        public const string ZRANGEBYLEX = "ZRANGEBYLEX";

        /// <summary>
        /// [SORTEDSETS] return a range of members in a sorted set, by score
        /// </summary>
        public const string ZRANGEBYSCORE = "ZRANGEBYSCORE";

        /// <summary>
        /// [SORTEDSETS] determine the index of a member in a sorted set
        /// </summary>
        public const string ZRANK = "ZRANK";

        /// <summary>
        /// [SORTEDSETS] remove one or more members from a sorted set
        /// </summary>
        public const string ZREM = "ZREM";

        /// <summary>
        /// [SORTEDSETS] remove all members in a sorted set between the given lexicographical range
        /// </summary>
        public const string ZREMRANGEBYLEX = "ZREMRANGEBYLEX";

        /// <summary>
        /// [SORTEDSETS] remove all members in a sorted set within the given indexes
        /// </summary>
        public const string ZREMRANGEBYRANK = "ZREMRANGEBYRANK";

        /// <summary>
        /// [SORTEDSETS] remove all members in a sorted set within the given scores
        /// </summary>
        public const string ZREMRANGEBYSCORE = "ZREMRANGEBYSCORE";

        /// <summary>
        /// [SORTEDSETS] return a range of members in a sorted set, by index, with scores ordered from high to low
        /// </summary>
        public const string ZREVRANGE = "ZREVRANGE";

        /// <summary>
        /// [SORTEDSETS] return a range of members in a sorted set, by score, with scores ordered from high to low
        /// </summary>
        public const string ZREVRANGEBYSCORE = "ZREVRANGEBYSCORE";

        /// <summary>
        /// [SORTEDSETS] determine the index of a member in a sorted set, with scores ordered from high to low
        /// </summary>
        public const string ZREVRANK = "ZREVRANK";

        /// <summary>
        /// [SORTEDSETS] get the score associated with the given member in a sorted set
        /// </summary>
        public const string ZSCORE = "ZSCORE";

        /// <summary>
        /// [SORTEDSETS] add multiple sorted sets and store the resulting sorted set in a new key
        /// </summary>
        public const string ZUNIONSTORE = "ZUNIONSTORE";

        /// <summary>
        /// [KEY] incrementally iterate the keys in the current keyspace
        /// </summary>
        public const string SCAN = "SCAN";

        /// <summary>
        /// [SETS] incrementally iterate set elements
        /// </summary>
        public const string SSCAN = "SSCAN";

        /// <summary>
        /// [HASHES] incrementally iterate hash fields and associated values
        /// </summary>
        public const string HSCAN = "HSCAN";

        /// <summary>
        /// [SORTEDSETS] incrementally iterate sorted sets elements and associated scores
        /// </summary>
        public const string ZSCAN = "ZSCAN";
    }
}
