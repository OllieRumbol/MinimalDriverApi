using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MinimalDriverDataAccess.DbAccess;

public class DatabaseConnectionFactory : IDatabaseConnectionFactory
{
    private readonly string _connectionId;
    private readonly IConfiguration _config;

    public DatabaseConnectionFactory(IConfiguration config, string connectionId = "Default")
    {
        _config = config;
        _connectionId = connectionId;
    }

    public IDbConnection GetConnection()
    {
        return new SqlConnection(_config.GetConnectionString(_connectionId));
    }
}
