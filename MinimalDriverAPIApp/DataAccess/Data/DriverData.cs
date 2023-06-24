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
}
