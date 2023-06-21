CREATE PROCEDURE [dbo].[spVehicle_GetAll]

AS
begin
	SELECT VehicleId, Registration, Miles, Make, Model, Colour
	FROM dbo.Vehicle;
end
