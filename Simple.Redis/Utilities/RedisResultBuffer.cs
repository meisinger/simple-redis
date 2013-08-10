using System.Collections.Generic;

namespace Simple.Redis.Utilities
{
    internal class RedisResultBuffer
    {
        private readonly List<RedisRecord> collection;

        internal RedisResultBuffer()
        {
            collection = new List<RedisRecord>();
        }

        internal void AddEmptyRecord()
        {
            collection.Add(RedisRecord.Nill(0));
        }

        internal void AddEmptyRecord(int index)
        {
            collection.Add(RedisRecord.Nill(index));
        }

        internal void AddRecord(string value)
        {
            collection.Add(new RedisRecord(0, value, false));
        }

        internal void AddRecord(int index, string value)
        {
            collection.Add(new RedisRecord(index, value, false));
        }

        internal RedisResult ToResult()
        {
            return new RedisResult(collection.ToArray());
        }
    }
}
