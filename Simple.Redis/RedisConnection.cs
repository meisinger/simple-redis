using System;
using System.IO;
using System.Net.Sockets;

namespace Simple.Redis
{
    public class RedisConnection : IDisposable
    {
        private readonly Socket socket;
        private readonly BufferedStream buffer;

        private RedisConnectionPool connectionPool;
        private bool active;

        public bool IsActive
        {
            get { return active; }
        }

        public bool IsOpen
        {
            get { return socket.Connected; }
        }

        public Stream RedisChannel
        {
            get { return buffer; }
        }

        public RedisConnection(Socket socket, BufferedStream buffer)
        {
            this.socket = socket;
            this.buffer = buffer;
        }

        public void Dispose()
        {
            if (connectionPool != null)
                connectionPool.DisposeConnection(this);
            else
                DisposeConnection();
        }

        internal void DisposeConnection()
        {
            buffer.Close();

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        internal void SetConnectionActive()
        {
            active = true;
        }

        internal void SetConnectionInactive()
        {
            active = false;
        }

        internal void SetConnectionPool(RedisConnectionPool pool)
        {
            connectionPool = pool;
        }
    }
}
