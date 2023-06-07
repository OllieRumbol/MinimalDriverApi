CREATE PROCEDURE [dbo].[spVehicle_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.Vehicle
	WHERE Id = @id;
end