using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IAllData
    {
        Task<AllModel> GetAll();
        Task<FullSchedule?> GetFullSchedule();
    }
}