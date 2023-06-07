
namespace DataAccess.Models;

public class ScheduleModel
{
    public int Id { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public DriverModel Driver { get; set; }

    public VehicleModel Vehicle { get; set; }
}
