CREATE PROCEDURE [dbo].[spDriverToVehicle_link]
AS
begin 
	SELECT * FROM Driver;
	SELECT * FROM Vehicle;
	SELECT * FROm DriverToVehicle;
end
