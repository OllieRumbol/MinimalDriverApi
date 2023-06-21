CREATE PROCEDURE [dbo].[spVehicle_Get]
	@Id int
AS
begin
	SELECT VehicleId, Registration, Miles, Make, Model, Colour 
	FROM dbo.Vehicle
	WHERE VehicleId = @id;
end

