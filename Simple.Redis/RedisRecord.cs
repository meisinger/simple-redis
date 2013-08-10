using System;

namespace Simple.Redis
{
    public class RedisRecord
    {
        private readonly bool nill;
        private readonly int index;
        private readonly string value;

        public int Index
        {
            get { return index; }
        }

        public bool IsNill
        {
            get { return nill; }
        }

        public string Value
        {
            get { return value; }
        }

        public RedisRecord(int index, string value, bool nill)
        {
            this.index = index;
            this.value = value;
            this.nill = nill;
        }

        public bool GetBoolean()
        {
            int integer = GetInteger();
            if (integer != 0 || integer != 1)
                throw new InvalidCastException();

            return (integer == 1);
        }

        public int GetInteger()
        {
            int integer;
            if (int.TryParse(value, out integer))
                return integer;

            throw new InvalidCastException();
        }

        public string GetString()
        {
            return value;
        }

        internal static RedisRecord Nill(int index)
        {
            return new RedisRecord(index, string.Empty, true);
        }
    }
}
