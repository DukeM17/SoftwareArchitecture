using SoftwareArchitecture.Design_Patterns.Creational_Patterns.ObjectPool;

var pool = new ConnectionPool(maxSize: 3);

var connection = pool.Rent();
connection.ExecuteQuery("SELECT * FROM mydatabase");
pool.Return(connection);

var connection2 = pool.Rent(); // The same connection is reused here
connection2.ExecuteQuery("SELECT * FROM mydatabase2");

var connection3 = pool.Rent(); // A new connection is made here
connection2.ExecuteQuery("SELECT * FROM mydatabase3");

pool.Return(connection2);
pool.Return(connection3);