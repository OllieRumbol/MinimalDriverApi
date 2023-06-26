CREATE PROCEDURE [dbo].[spSchedule_Get]
	@Id int
AS
begin
	SELECT ScheduleId, StartDateTime, EndDateTime, DriverId, VehicleId, Priority_Level
	FROM dbo.Schedule
	WHERE ScheduleId = @id;
end

