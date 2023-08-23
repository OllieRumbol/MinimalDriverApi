using Dapper;

namespace MinimalDriverDataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task ExecuteData<TParameters>(string storedProcedure, TParameters parameters);
        Task<IEnumerable<TReturnedDataModel>> QueryData<TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters);
        Task QueryMultipleDataSets<TParameters>(string storedProcedure, TParameters parameters, Action<SqlMapper.GridReader> callback);
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TReturnedDataModel> map, string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel> map, string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel> map, string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel> map, string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TForth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TReturnedDataModel> map, string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> QueryMultipleObjectData<TFirst, TSecond, TThird, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TReturnedDataModel> map, string splitOn = "Id");
    }
}