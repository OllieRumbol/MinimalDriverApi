namespace DataAccess.Models;

public class FullSchedule
{
    public DriverModel Driver { get; set; }

    public ScheduleModel Schedule { get; set; }

    public VehicleModel Vehicle { get; set; }
}
