using Dapper;
using DataAccess.DbAccess;
using DataAccess.Models;
using System.Data;

namespace DataAccess.Data;

public class AllData : IAllData
{
    private readonly ISqlDataAccess _db;

    public AllData(ISqlDataAccess db)
    {
        _db = db;
    }
    public async Task<AllModel> GetAll()
    {
        using IDbConnection connection = _db.GetConnection();

        var results = await connection.QueryMultipleAsync(
                sql: "spDriverVehicleSchedule_GetAll2",
                param: new { },
                commandType: CommandType.StoredProcedure
            );

        var drivers = results.Read<DriverModel>().ToList();
        var schedules = results.Read<ScheduleModel>().ToList();
        var vehicles = results.Read<VehicleModel>().ToList();

        return new AllModel
        {
            Drivers = drivers,
            Schedules = schedules,
            Vehicles = vehicles
        };
    }
}
