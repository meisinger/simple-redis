using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Simple.Redis
{
    public class RedisResult : IEnumerator<RedisRecord>, IEnumerable<RedisRecord>
    {
        private readonly RedisRecord[] collection;
        private int currentIndex;

        public RedisRecord this[int index]
        {
            get
            {
                var item = collection.FirstOrDefault(x => x.Index.Equals(index));
                if (item == null)
                    throw new IndexOutOfRangeException();

                return item;
            }
        }

        object IEnumerator.Current
        {
            get { return collection[currentIndex]; }
        }

        RedisRecord IEnumerator<RedisRecord>.Current
        {
            get { return collection[currentIndex]; }
        }

        public bool IsEmpty
        {
            get { return (collection.Length == 0); }
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public RedisResult(RedisRecord[] collection)
        {
            this.collection = collection;
            currentIndex = -1;
        }

        public void Dispose()
        {
            currentIndex = -1;
        }

        IEnumerator<RedisRecord> IEnumerable<RedisRecord>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            currentIndex++;
            return (currentIndex < collection.Length);
        }

        void IEnumerator.Reset()
        {
            currentIndex = -1;
        }
    }
}
