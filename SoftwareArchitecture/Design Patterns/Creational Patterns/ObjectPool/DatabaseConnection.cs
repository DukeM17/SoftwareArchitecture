using System.Collections.Concurrent;

namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.ObjectPool
{
    public class DatabaseConnection
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsOpen { get; private set; }

        public void Open() { IsOpen = true; Console.WriteLine($"Connection {Id} is open"); }
        public void Close() { IsOpen = false; Console.WriteLine($"Connection {Id} is closed"); }
        public void Reset() { /* clear state for reuse */ }
        public void ExecuteQuery(string sql) => Console.WriteLine($"[{Id}] Running: {sql}");
    }

    public class ConnectionPool
    {
        private readonly ConcurrentQueue<DatabaseConnection> _available = new(); // a list of database connections that are available
        private readonly int _maxSize = 10;
        private int _totalCreated;

        public ConnectionPool(int maxSize)
        {  _maxSize = maxSize; }

        public DatabaseConnection Rent()
        {
            if (_available.TryDequeue(out var connection))
            {
                Console.WriteLine($"Reusing connection {connection.Id}");
                return connection;
            }

            if (_totalCreated > _maxSize)
                throw new InvalidOperationException("Connection pool exhausted - no connection was available");

            // otherwise, make a new connection
            var newConnection = new DatabaseConnection();
            newConnection.Open();
            Interlocked.Increment(ref _totalCreated);
            return newConnection;
        }

        public void Return(DatabaseConnection connection)
        {
            connection.Reset();
            _available.Enqueue(connection);
            Console.WriteLine($"Connection {connection.Id} returned to pool");
        }
    }
}
