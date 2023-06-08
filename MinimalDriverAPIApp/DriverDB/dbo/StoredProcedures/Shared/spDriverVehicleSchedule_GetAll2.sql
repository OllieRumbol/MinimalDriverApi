CREATE PROCEDURE [dbo].[spDriverVehicleSchedule_GetAll2]
as
begin
	SELECT * FROM dbo.Driver;
	SELECT * FROM dbo.Schedule;
	SELECt * FROM dbo.Vehicle;
end
