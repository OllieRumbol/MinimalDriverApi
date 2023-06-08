CREATE PROCEDURE [dbo].[spDriverVehicleSchedule_GetAll]
AS
begin 
	SELECT * FROM dbo.Driver dri RIGHT JOIN dbo.Schedule sch on dri.Id = sch.DriverId LEFT JOIN dbo.Vehicle veh ON sch.VehicleId = veh.Id; 
end