CREATE PROCEDURE [dbo].[spVehicle_Update]
	@Id int,
	@Registration nvarchar(10),
	@Miles int,
	@Make nvarchar(50),
	@Model nvarchar(50),
	@Colour nvarchar(50)
AS
begin
	UPDATE dbo.Vehicle
	SET Registration = @Registration, Miles = @Miles, Make = @Make, Model = @Model, Colour = @Colour
	WHERE Id = @Id
end
