CREATE PROCEDURE [dbo].[spSchedule_Update]
	@Id int,
	@StartDateTime DateTime,
	@EndDateTime DateTime,
	@DriverId int,
	@VehicleId int
AS
begin
	UPDATE dbo.Schedule
	SET StartDateTime = @StartDateTime, EndDateTime = @EndDateTime, DriverId = @DriverId, VehicleId = @VehicleId
	WHERE Id = @Id
end
