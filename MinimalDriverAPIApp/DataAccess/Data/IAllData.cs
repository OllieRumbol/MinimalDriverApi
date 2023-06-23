using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data
{
    public interface IAllData
    {
        Task<AllModel> GetAll();
        Task<List<FullSchedule>> GetFullSchedule();
    }
}