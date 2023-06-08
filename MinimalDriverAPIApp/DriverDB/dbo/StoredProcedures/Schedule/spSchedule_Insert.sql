CREATE PROCEDURE [dbo].[spSchedule_Insert]
	@StartDateTime DateTime,
	@EndDateTime DateTime,
	@DriverId int,
	@VehicleId int
AS
begin
	INSERT INTO dbo.Schedule (StartDateTime, EndDateTime, DriverId, VehicleId)
	VALUES (@StartDateTime, @EndDateTime, @DriverId, @VehicleId);
end
