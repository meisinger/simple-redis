using System.IO;
using System.Net.Sockets;

namespace Simple.Redis
{
    /// <summary>
    /// Constructs Redis Connection instances
    /// </summary>
    public class RedisConnectionFactory
    {
        private readonly string host;
        private readonly string password;
        private readonly int port;
        private readonly int? keyspace;

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        public RedisConnectionFactory(string host)
            : this(host, string.Empty, 6379)
        {
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="port">port number</param>
        public RedisConnectionFactory(string host, int port)
            : this(host, string.Empty, port)
        {
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="password">Redis password</param>
        /// <param name="port">port number</param>
        public RedisConnectionFactory(string host, string password, int port)
        {
            this.host = host;
            this.password = password;
            this.port = port;
            this.keyspace = null;
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="port">port number</param>
        /// <param name="keyspace">Redis keyspace</param>
        public RedisConnectionFactory(string host, int port, int keyspace)
            : this(host, string.Empty, port, keyspace)
        {   
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="password">Redis password</param>
        /// <param name="port">port number</param>
        /// <param name="keyspace">Redis keyspace</param>
        public RedisConnectionFactory(string host, string password, int port, int keyspace)
        {
            this.host = host;
            this.password = password;
            this.port = port;
            this.keyspace = keyspace;
        }

        /// <summary>
        /// Opens a connection using the supplied values
        /// </summary>
        /// <returns></returns>
        public RedisConnection Open()
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.NoDelay = true;
            socket.SendTimeout = -1;
            socket.Connect(host, port);

            if (!socket.Connected)
            {
                socket.Close();
                throw new SocketException();
            }

            var stream = new NetworkStream(socket);
            var buffer = new BufferedStream(stream, 16 * 1024);
            var connection = new RedisConnection(socket, buffer);

            return connection;
        }
    }
}
