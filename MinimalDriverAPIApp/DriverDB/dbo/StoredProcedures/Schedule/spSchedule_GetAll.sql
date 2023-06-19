CREATE PROCEDURE [dbo].[spSchedule_GetAll]

AS
begin
	SELECT ScheduleId, StartDateTime, EndDateTime, DriverId, VehicleId 
	FROM dbo.Schedule;
end
