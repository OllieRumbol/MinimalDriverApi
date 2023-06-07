using Dapper;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        SqlConnection GetConnection(string connectionId = "Default");
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
        Task<SqlMapper.GridReader> LoadMultipleData<T>(string storedProcedure, T parameters, string connectionId = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}