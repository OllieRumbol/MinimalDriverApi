﻿using MinimalDriverModels;

namespace MinimalDriverDataAccess.Data
{
    public interface IScheduleData
    {
        Task DeleteSchedule(int id);
        Task<ScheduleModel?> GetSchedule(int id);
        Task<IEnumerable<ScheduleModel>> GetSchedules();
        Task InsertSchedule(ScheduleModel schedule);
        Task UpdateSchedule(ScheduleModel schedule);
    }
}