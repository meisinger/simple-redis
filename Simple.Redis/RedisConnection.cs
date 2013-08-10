using Simple.Redis.Utilities;
using System;
using System.IO;
using System.Net.Sockets;

namespace Simple.Redis
{
    public class RedisConnection
    {
        private readonly Socket socket;
        private readonly BufferedStream buffer;

        public bool IsOpen
        {
            get { return socket.Connected; }
        }

        public RedisConnection(Socket socket, BufferedStream buffer)
        {
            this.socket = socket;
            this.buffer = buffer;
        }

        public void Dispose()
        {
            buffer.Close();
            socket.Close();
        }

        public RedisResult Execute(RedisCommand command)
        {
            if (!socket.Connected)
                throw new InvalidOperationException();

            command.ExecuteCommand(buffer);

            var reader = new RedisReader(buffer);
            return reader.Parse();
        }
    }
}
