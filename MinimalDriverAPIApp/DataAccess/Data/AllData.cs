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

    public async Task<FullSchedule?> GetFullSchedule()
    {
        using IDbConnection connection = _db.GetConnection();

        var results = await connection
            .QueryAsync<DriverModel, ScheduleModel, VehicleModel, FullSchedule>(
                sql: "spDriverVehicleSchedule_GetAll",
                map: (driver, schedule, vehicle) => new FullSchedule
                {
                    Driver = driver,
                    Schedule = schedule,
                    Vehicle = vehicle
                },
                param: new { },
                commandType: CommandType.StoredProcedure);

        return results.FirstOrDefault();
    }

    public async Task<AllModel> GetAll()
    {
        //var results = await _db.LoadMultipleData("spDriverVehicleSchedule_GetAll2", new { });

        using IDbConnection connection = _db.GetConnection();

        var results = await connection.QueryMultipleAsync(
            "spDriverVehicleSchedule_GetAll2", new { },
    commandType: CommandType.StoredProcedure);


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
