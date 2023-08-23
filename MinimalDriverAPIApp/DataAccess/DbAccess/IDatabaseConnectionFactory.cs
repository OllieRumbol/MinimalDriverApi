using System.Data;

namespace MinimalDriverDataAccess.DbAccess
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}