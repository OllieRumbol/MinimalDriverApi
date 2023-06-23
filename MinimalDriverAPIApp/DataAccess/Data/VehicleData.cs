using MinimalDriverDataAccess.DbAccess;
using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data;

public class VehicleData : IVehicleData
{
    private readonly ISqlDataAccess _db;

    public VehicleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<VehicleModel>> GetVehicles() => _db.LoadData<VehicleModel, dynamic>("dbo.spVehicle_GetAll", new { });

    public async Task<VehicleModel?> GetVehicle(int id)
    {
        var results = await _db.LoadData<VehicleModel, dynamic>("dbo.spVehicle_Get", new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertVehicle(VehicleModel vehicle) => _db.SaveData("dbo.spVehicle_Insert", new { vehicle.Registration, vehicle.Miles, vehicle.Make, vehicle.Model, vehicle.Colour });

    public Task UpdateVehicle(VehicleModel vehicle) => _db.SaveData("dbo.spVehicle_Update", vehicle);

    public Task DeleteVehicle(int id) => _db.SaveData("dbo.spVehicle_Delete", new { Id = id });
}
