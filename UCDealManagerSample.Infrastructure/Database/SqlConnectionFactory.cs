using System;
using System.Data;
using System.Data.SqlClient;
using UCDealManagerSample.Application.Configuration.Data;

namespace UCDealManagerSample.Infrastructure.Database
{
    public class SqlConnectionFactory : ISqlConnectionFactory, IDisposable
    {

        private readonly string _connectionString;
        private IDbConnection _connection;
        public void Dispose()
        {
            if (_connection != null && _connection.State != ConnectionState.Open)
            {
                _connection.Dispose();
            }
        }

        // change using oracle data provider
        public IDbConnection GetOpenConnection()
        {
            if(_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }

            return _connection;
        }

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
