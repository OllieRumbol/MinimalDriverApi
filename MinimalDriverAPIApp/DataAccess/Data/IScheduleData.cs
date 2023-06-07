using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IScheduleData
    {
        Task<ScheduleModel?> GetSchedules();
    }
}