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
                List<DriverToVehicle> driverToVehicles = reader.Read<DriverToVehicle>().ToList();

                Dictionary<int, List<VehicleModel>> results2 = driverToVehicles.GroupBy(
                    d => d.DriverId,
                    d => d.VehicleId,
                    (key, list) => new KeyValuePair<int, List<VehicleModel>>(
                        key,
                        vehicles.Where(v => list.Contains(v.VehicleId)).ToList()
                      )
                    )
                .ToDictionary(d => d.Key, d => d.Value);

                results = drivers.Select(d =>
                {
                    d.Vehicles = results2.GetValueOrDefault(d.DriverId);
                    return d;
                }).ToList();
            });

        return results;
    }
}
