CREATE PROCEDURE [dbo].[spVehicle_Get]
	@Id int
AS
begin
	SELECT * 
	FROM dbo.Vehicle
	WHERE Id = @id;
end

