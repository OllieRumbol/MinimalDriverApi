CREATE PROCEDURE [dbo].[spSchedule_Insert]
	@StartDateTime DateTime,
	@EndDateTime DateTime,
	@DriverId int,
	@VehicleId int,
	@PriorityLevel int
AS
begin
	INSERT INTO dbo.Schedule (StartDateTime, EndDateTime, DriverId, VehicleId, Priority_Level)
	VALUES (@StartDateTime, @EndDateTime, @DriverId, @VehicleId, @PriorityLevel);
end
