using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data
{
    public interface IDriverData
    {
        Task DeleteDriver(int id);
        Task<DriverModel?> GetDriver(int id);
        Task<IEnumerable<DriverModel>> GetDrivers();
        Task InsertALotOfDrivers();
        Task InsertDriver(DriverModel driver);
        Task<IEnumerable<DriverWithVehiclesModel>> LinkDrivers();
        Task UpdateDriver(DriverModel driver);
    }
}