using Simple.Redis.Extensions;
using Simple.Redis.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Simple.Redis
{
    public class RedisCommand
    {
        private readonly List<byte[]> collection;

        public RedisCommand(byte[][] arguments)
        {
            collection = new List<byte[]>(100);
            collection.AddRange(arguments);
        }

        public RedisCommand AddArgument(byte[] argument)
        {
            collection.Add(argument);
            return this;
        }

        public RedisCommand AddArgument(string argument)
        {
            collection.Add(Encoding.UTF8.GetBytes(argument));
            return this;
        }

        public RedisCommand AddArgument(int argument)
        {
            collection.Add(Encoding.UTF8.GetBytes(argument.ToString()));
            return this;
        }

        public RedisCommand AddArgument<T>(T argument)
            where T : class
        {
            var bytes = RedisSerializer.SerializeToBytes(argument);

            collection.Add(bytes);
            return this;
        }

        public RedisResult Execute(RedisConnection connection)
        {
            if (!connection.IsOpen)
                throw new InvalidOperationException("Connection must be open.");

            var bytes = GenerateCommand(collection.ToArray());

            var channel = connection.RedisChannel;
            channel.Write(bytes, 0, bytes.Length);
            channel.Flush();

            var reader = new RedisReader(channel);
            return reader.Parse();
        }

        public static RedisCommand Create(string command)
        {
            if (!RedisCommandMapping.IsValidCommand(command))
            {
                var message = string.Format("The command \"{0}\" is not a valid Redis command or is not understood.", command);
                throw new InvalidOperationException(message);
            }

            return RedisCommandMapping.GenerateCommand(command);
        }

        private static byte[] GenerateCommand(byte[][] arguments)
        {
            using (var stream = new MemoryStream())
            {
                var header = CreateIndicator('*', arguments.Length);
                stream.Write(header, 0, header.Length);
                stream.WriteNewLine();

                for (int index = 0; index < arguments.Length; index++)
                {
                    var argument = arguments[index];
                    var body = CreateIndicator('$', argument.Length);
                    stream.Write(body, 0, body.Length);
                    stream.WriteNewLine();
                    stream.Write(argument, 0, argument.Length);
                    stream.WriteNewLine();
                }

                return stream.ToArray();
            }
        }

        private static byte[] CreateIndicator(char indicator, int count)
        {
            var value = count.ToString();
            var length = value.Length;
            var bytes = new byte[length + 1];

            bytes[0] = (byte)indicator;
            for (int byteIndex = 1, index = 0; index < length; byteIndex++, index++)
                bytes[byteIndex] = (byte)value[index];

            return bytes;
        }
    }
}
