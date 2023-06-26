using MinimalDriverDataAccess.DbAccess;
using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data;

public class ScheduleData : IScheduleData
{
    private readonly ISqlDataAccess _db;

    public ScheduleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ScheduleModel>> GetSchedules() => _db.LoadData<ScheduleModel, dynamic>("dbo.spSchedule_GetAll", new { });

    public async Task<ScheduleModel?> GetSchedule(int id)
    {
        var results = await _db.LoadData<ScheduleModel, dynamic>("dbo.spSchedule_Get", new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertSchedule(ScheduleModel schedule) => _db.SaveData("dbo.spSchedule_Insert", new { schedule.StartDateTime, schedule.EndDateTime, schedule.DriverId, schedule.VehicleId, schedule.PriorityLevel });

    public Task UpdateSchedule(ScheduleModel schedule) => _db.SaveData("dbo.spSchedule_Update", schedule);

    public Task DeleteSchedule(int id) => _db.SaveData("dbo.spSchedule_Delete", new { Id = id });
}
