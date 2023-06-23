using Dapper;
using MinimalDriverDataAccess.DbAccess;
using MinimalDriverModels;
using System.Data;

namespace MinimalDriverDataAccess.Data;

public class AllData : IAllData
{
    private readonly ISqlDataAccess _db;

    public AllData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<List<FullSchedule>> GetFullSchedule()
    {
        var results = await _db.LoadMultipleObjectData<DriverModel, ScheduleModel, VehicleModel, FullSchedule, dynamic>(
            storedProcedure: "spDriverVehicleSchedule_GetAll",
            parameters: new { },
            map: (driver, schedule, vehicle) => new FullSchedule
            {
                Driver = driver,
                Schedule = schedule,
                Vehicle = vehicle
            },
            splitOn: "ScheduleId,DriverId");

        return results.ToList();
    }

    public async Task<AllModel> GetAll()
    {
        using IDbConnection connection = _db.GetConnection();

        var results = await connection.QueryMultipleAsync("spDriverVehicleSchedule_GetAll2", new { }, commandType: CommandType.StoredProcedure);

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
