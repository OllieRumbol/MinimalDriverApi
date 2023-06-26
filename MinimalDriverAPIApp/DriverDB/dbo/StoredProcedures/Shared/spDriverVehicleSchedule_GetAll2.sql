CREATE PROCEDURE [dbo].[spDriverVehicleSchedule_GetAll2]
as
begin
	SELECT DriverId, FirstName, LastName, DateOfBirth, DrivingLicenceNumber FROM dbo.Driver;
	SELECT ScheduleId, StartDateTime, EndDateTime, DriverId, VehicleId, Priority_Level FROM dbo.Schedule;
	SELECt VehicleId, Registration, Miles, Make, Model, Colour FROM dbo.Vehicle;
end
