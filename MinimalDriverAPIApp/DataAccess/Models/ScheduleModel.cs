namespace DataAccess.Models;

public class ScheduleModel
{
    public int Id { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public int DriverId { get; set; }

    public int VehicleId { get; set; }
}
