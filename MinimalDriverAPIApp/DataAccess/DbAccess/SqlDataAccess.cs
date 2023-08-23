using Dapper;
using System.Data;

namespace MinimalDriverDataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IDatabaseConnectionFactory _databaseConnectionFactory;

    public SqlDataAccess(IDatabaseConnectionFactory databaseConnectionFactory)
    {
        _databaseConnectionFactory = databaseConnectionFactory;
        DefaultTypeMap.MatchNamesWithUnderscores = true;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryData<TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters)
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        return await connection.QueryAsync<TReturnedDataModel>(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);
    }

    public async Task ExecuteData<TParameters>(
        string storedProcedure,
        TParameters parameters)
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel, TParameters>(
        string storedProcedure,
        TParameters parameters,
        Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel> map,
        string splitOn = "Id")
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection
            .QueryAsync<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel>(
                sql: storedProcedure,
                param: parameters,
                map: map,
                splitOn: splitOn,
                commandType: CommandType.StoredProcedure);

        return results;
    }

    public async Task QueryMultipleDataSets<TParameters>(
        string storedProcedure,
        TParameters parameters,
        Action<SqlMapper.GridReader> callback)
    {
        using IDbConnection connection = _databaseConnectionFactory.GetConnection();

        var results = await connection.QueryMultipleAsync(
            sql: storedProcedure,
            param: parameters,
            commandType: CommandType.StoredProcedure);

        callback(results);
    }
}
