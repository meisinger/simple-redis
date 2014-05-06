using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple.Redis
{
    public class RedisConnectionPool : IDisposable
    {
        private readonly object sync = new object();

        private readonly RedisConnection[] connections;
        private readonly string hostName;
        private readonly int portNumber;
        private readonly TimeSpan timeout;
        private int disposeCounter;

        public RedisConnectionPool(string hostName, int portNumber)
            : this(hostName, portNumber, TimeSpan.FromSeconds(2))
        {
        }

        public RedisConnectionPool(string hostName, int portNumber, TimeSpan timeout)
            : this(hostName, portNumber, 100, timeout)
        {
        }

        public RedisConnectionPool(string hostName, int portNumber, int poolSize, TimeSpan timeout)
        {
            this.hostName = hostName;
            this.portNumber = portNumber;
            this.timeout = timeout;

            connections = new RedisConnection[poolSize];
        }

        ~RedisConnectionPool()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DisposeConnection(RedisConnection connection)
        {
            lock (connections)
            {
                connection.SetConnectionInactive();
                Monitor.PulseAll(connections);
            }
        }

        public RedisConnection GetConnection()
        {
            lock (connections)
            {
                RedisConnection connection;
                while ((connection = IdentifyAvailableConnection()) == null)
                {
                    if (Monitor.Wait(connections, timeout))
                        throw new TimeoutException("Unable to establish a connection within the given time frame.");
                }

                connection.SetConnectionActive();
                return connection;
            }
        }

        public RedisConnection IdentifyAvailableConnection()
        {
            for (int index = 0; index < connections.Length; index++)
            {
                var connection = connections[index];
                if (connection != null && connection.IsOpen && !connection.IsActive)
                    return connection;

                if (connection == null || !connection.IsOpen)
                {
                    if (connection != null)
                        connection.DisposeConnection();

                    var instance = RedisConnectionFactory.CreateConnection(hostName, portNumber);
                    instance.SetConnectionPool(this);

                    connections[index] = instance;
                    return instance;
                }
            }

            return null;
        }

        private void Dispose(bool disposing)
        {
            if (Interlocked.Increment(ref disposeCounter) > 1)
                return;

            for (int index = 0; index < connections.Length; index++)
            {
                var connection = connections[index];
                if (connection == null)
                    continue;

                connection.DisposeConnection();
                connections[index] = null;
            }
        }
    }
}
