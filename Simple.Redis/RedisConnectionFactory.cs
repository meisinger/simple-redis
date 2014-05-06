using System;
using System.IO;
using System.Net.Sockets;

namespace Simple.Redis
{
    /// <summary>
    /// Constructs Redis Connection instances
    /// </summary>
    public class RedisConnectionFactory : IDisposable
    {
        private readonly string host;
        private readonly string password;
        private readonly int keyspace;
        private readonly int port;
        private readonly int poolSize;
        private readonly TimeSpan timeout;

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        public RedisConnectionFactory(string host)
            : this(host, string.Empty, 6379, 0, 100, 2)
        {
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="port">port number</param>
        public RedisConnectionFactory(string host, int port)
            : this(host, string.Empty, port, 0, 100, 2)
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
            : this(host, password, port, 0, 100, 2)
        {
        }

        /// <summary>
        /// Construct a connection factory to connect
        /// to the given Redis host
        /// </summary>
        /// <param name="host">Redis host name</param>
        /// <param name="port">port number</param>
        /// <param name="keyspace">Redis keyspace</param>
        public RedisConnectionFactory(string host, int port, int keyspace)
            : this(host, string.Empty, port, keyspace, 100, 2)
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
            : this(host, password, port, keyspace, 100, 2)
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
        /// <param name="poolSize">connection pool size</param>
        /// <param name="poolTimeout">connection pool timeout</param>
        public RedisConnectionFactory(string host, string password, int port, int keyspace, int poolSize, int poolTimeout)
        {
            this.host = host;
            this.password = password;
            this.port = port;
            this.keyspace = keyspace;
            this.poolSize = poolSize;

            timeout = TimeSpan.FromSeconds(poolTimeout);
        }

        public void Dispose()
        {
            RedisConnectionManager
                .DisposeConnectionPool();
        }

        public RedisConnection GetConnection()
        {
            var pool = RedisConnectionManager
                .IdentifyConnectionPool(host, port, poolSize, timeout);

            return pool.GetConnection();
        }

        /// <summary>
        /// Opens a connection using the supplied values
        /// </summary>
        /// <returns></returns>
        public RedisConnection Open()
        {
            var connection = GetConnection();
            if (!string.IsNullOrWhiteSpace(password))
            {
                var authorized = RedisCommand.Create(RedisCommands.AUTH)
                    .AddArgument(password)
                    .Execute(connection);

                if (authorized.IsEmpty)
                {
                    connection.Dispose();
                    throw new Exception("Authentication failed.");
                }

                var authorizedStatus = authorized[0].GetString();
                if (!authorizedStatus.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    connection.Dispose();
                    throw new Exception("Authentication failed.");
                }
            }

            if (keyspace.Equals(0))
                return connection;

            var changedKeySpace = RedisCommand.Create(RedisCommands.SELECT)
                .AddArgument(keyspace)
                .Execute(connection);

            if (changedKeySpace.IsEmpty)
            {
                connection.Dispose();
                var message = string.Format("Keyspace \"{0}\" does not exist or is not available.", keyspace);
                throw new Exception(message);
            }

            var changedStatus = changedKeySpace[0].GetString();
            if (!changedStatus.Equals("OK", StringComparison.OrdinalIgnoreCase))
            {
                connection.Dispose();
                var message = string.Format("Keyspace \"{0}\" does not exist or is not available.", keyspace);
                throw new Exception(message);
            }

            return connection;
        }

        public static RedisConnection CreateConnection(string hostName, int portNumber)
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.NoDelay = true;
            socket.SendTimeout = -1;
            socket.Connect(hostName, portNumber);

            if (!socket.Connected)
            {
                socket.Dispose();
                throw new IOException();
            }

            var stream = new BufferedStream(new NetworkStream(socket), 16 * 1024);
            var connection = new RedisConnection(socket, stream);

            return connection;
        }
    }
}
