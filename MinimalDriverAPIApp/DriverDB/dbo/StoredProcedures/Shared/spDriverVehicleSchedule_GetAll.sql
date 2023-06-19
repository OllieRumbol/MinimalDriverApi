CREATE PROCEDURE [dbo].[spDriverVehicleSchedule_GetAll]
AS
begin 
	SELECT
	dri.DriverId, dri.FirstName, dri.LastName, dri.DateOfBirth, dri.DrivingLicenceNumber,
	sch.ScheduleId, sch.StartDateTime, sch.EndDateTime, sch.DriverId, sch.VehicleId,
	veh.VehicleId, veh.Registration, veh.Miles, veh.Make, veh.Model, veh.Colour 
	FROM dbo.Driver dri 
	RIGHT JOIN dbo.Schedule sch on dri.DriverId = sch.DriverId 
	LEFT JOIN dbo.Vehicle veh ON sch.VehicleId = veh.VehicleId; 
end