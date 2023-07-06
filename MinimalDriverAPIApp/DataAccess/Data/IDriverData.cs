using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data
{
    public interface IDriverData
    {
        Task DeleteDriver(int id);
        Task<DriverModel?> GetDriver(int id);
        Task<IEnumerable<DriverModel>> GetDrivers();
        Task InsertDriver(DriverModel driver);
        Task<IEnumerable<DriverModel>> LinkDrivers();
        Task UpdateDriver(DriverModel driver);
    }
}