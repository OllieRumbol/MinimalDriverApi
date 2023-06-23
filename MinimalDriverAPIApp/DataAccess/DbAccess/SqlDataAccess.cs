using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace MinimalDriverDataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadData<TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryAsync<TReturnedDataModel>(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<TParameters>(
        string storedProcedure,
        TParameters parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel> map,
        string connectionId = "Default",
        string splitOn = "Id")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public SqlConnection GetConnection(string connectionId = "Default")
    {
        return new SqlConnection(_config.GetConnectionString(connectionId));
    }
}
