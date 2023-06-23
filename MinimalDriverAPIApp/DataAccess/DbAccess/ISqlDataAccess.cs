using System.Data.SqlClient;

namespace MinimalDriverDataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        SqlConnection GetConnection(string connectionId = "Default");
        Task<IEnumerable<TReturnedDataModel>> LoadData<TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, string connectionId = "Default");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TFifth, TSixth, TSeventh, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TForth, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TForth, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task<IEnumerable<TReturnedDataModel>> LoadMultipleObjectData<TFirst, TSecond, TThird, TReturnedDataModel, TParameters>(string storedProcedure, TParameters parameters, Func<TFirst, TSecond, TThird, TReturnedDataModel> map, string connectionId = "Default", string splitOn = "Id");
        Task SaveData<TParameters>(string storedProcedure, TParameters parameters, string connectionId = "Default");
    }
}