using MinimalDriverDataAccess.DbAccess;
using MinimalDriverDataAccess.Extensions;
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


    public Task InsertALotOfDrivers()
    {
        List<DriverModel> drivers = new List<DriverModel>
        {
            new DriverModel
            {
                FirstName = "Ollie",
                LastName = "Bourne",
                DateOfBirth = DateTime.Now,
                DrivingLicenceNumber = "abc123"

            },
            new DriverModel
            {
                FirstName = "Ollie",
                LastName = "Bourne",
                DateOfBirth = DateTime.Now,
                DrivingLicenceNumber = "abc123"

            },
            new DriverModel()
            {
                FirstName = "Ollie",
                LastName = "Bourne",
                DateOfBirth = DateTime.Now,
                DrivingLicenceNumber = "abc123"

            }
        };

        return _db.SaveData("dbo.spDriver_InsertAll", new { drivers = drivers.ToDataTable() });
    }


    public async Task<IEnumerable<DriverWithVehiclesModel>> LinkDrivers()
    {
        List<DriverWithVehiclesModel> results = new List<DriverWithVehiclesModel>();

        await _db.LoadMultipleDataSets(
            storedProcedure: "spDriverToVehicle_link",
            parameters: new { },
            (reader) =>
            {
                List<DriverWithVehiclesModel> drivers = reader.Read<DriverWithVehiclesModel>().ToList();
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
