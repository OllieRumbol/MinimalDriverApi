using MinimalDriverDataAccess.DbAccess;
using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data;

public class DriverData : IDriverData
{
    private readonly ISqlDataAccess _db;

    public DriverData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<DriverModel>> GetDrivers() => _db.LoadData<DriverModel, dynamic>("dbo.spDriver_GetAll", new { });

    public async Task<DriverModel?> GetDriver(int id)
    {
        var results = await _db.LoadData<DriverModel, dynamic>("dbo.spDriver_Get", new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertDriver(DriverModel driver) => _db.SaveData("dbo.spDriver_Insert", new { driver.FirstName, driver.LastName, driver.DateOfBirth, driver.DrivingLicenceNumber });

    public Task UpdateDriver(DriverModel driver) => _db.SaveData("dbo.spDriver_Update", driver);

    public Task DeleteDriver(int id) => _db.SaveData("dbo.spDriver_Delete", new { Id = id });

    public async Task<IEnumerable<DriverModel>> LinkDrivers()
    {
        List<DriverModel> results = new List<DriverModel>();

        await _db.LoadMultipleDataSets(
            storedProcedure: "spDriverToVehicle_link",
            parameters: new { },
            (reader) =>
            {
                List<DriverModel> drivers = reader.Read<DriverModel>().ToList();
                List<VehicleModel> vehicles = reader.Read<VehicleModel>().ToList();
                Dictionary<int, List<VehicleModel>> driverToVehicles = reader.Read<DriverToVehicle>().GroupBy(
                    d => d.DriverId,
                    d => d.VehicleId,
                    (key, list) => new 
                    {
                        DriverId = key,
                        Vehicles = vehicles.Where(v => list.Contains(v.VehicleId)).ToList()
                    })
                .ToDictionary(d => d.DriverId, d => d.Vehicles);

                results = drivers.Select(d =>
                {
                    d.Vehicles = driverToVehicles.GetValueOrDefault(d.DriverId);
                    return d;
                }).ToList();
            });

        return results;
    }
}
