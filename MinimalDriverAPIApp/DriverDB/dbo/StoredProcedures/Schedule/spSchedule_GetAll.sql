CREATE PROCEDURE [dbo].[spSchedule_GetAll]

AS
begin
	SELECT ScheduleId, StartDateTime, EndDateTime, DriverId, VehicleId, Priority_Level
	FROM dbo.Schedule;
end
