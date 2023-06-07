using Dapper;
using DataAccess.DbAccess;
using DataAccess.Models;
using System.Data;

namespace DataAccess.Data;

public class ScheduleData : IScheduleData
{
    private readonly ISqlDataAccess _db;

    public ScheduleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<ScheduleModel?> GetSchedules()
    {
        using IDbConnection connection = _db.GetConnection();

        var results = await connection
            .QueryAsync<DriverModel, ScheduleModel, VehicleModel, ScheduleModel>(
                sql: "spDriverVehicleSchedule_GetAll",
                map: (driver, schedule, vehicle) =>
                {
                    schedule.Driver = new DriverModel
                    {
                        Id = driver.Id,
                        FirstName = driver.FirstName,
                        LastName = driver.LastName,
                        DateOfBirth = driver.DateOfBirth,
                        DrivingLicenceNumber = driver.DrivingLicenceNumber
                    };

                    schedule.Vehicle = new VehicleModel
                    {
                        Id = vehicle.Id,
                        Registration = vehicle.Registration,
                        Miles = vehicle.Miles,
                        Make = vehicle.Make,
                        Model = vehicle.Model,
                        Colour = vehicle.Colour,
                    };

                    return schedule;
                },
                param: new { },
                commandType: CommandType.StoredProcedure);

        return results.FirstOrDefault();
    }
}
