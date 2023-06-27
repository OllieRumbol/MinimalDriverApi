using MinimalDriverDataAccess.DbAccess;
using MinimalDriverModels;

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
            splitOn: "ScheduleId,VehicleId");

        return results.ToList();
    }

    public async Task<AllModel> GetAll()
    {
        var allModel = new AllModel();

        await _db.LoadMultipleDataSets(
            storedProcedure: "spDriverVehicleSchedule_GetAll2",
            parameters: new { },
            (reader) =>
            {
                allModel.Drivers = reader.Read<DriverModel>().ToList();
                allModel.Schedules = reader.Read<ScheduleModel>().ToList();
                allModel.Vehicles = reader.Read<VehicleModel>().ToList();
            });

        return allModel;
    }
}
