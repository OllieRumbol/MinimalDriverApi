CREATE PROCEDURE [dbo].[spVehicle_Insert]
	@Registration nvarchar(10),
	@Miles int,
	@Make nvarchar(50),
	@Model nvarchar(50),
	@Colour nvarchar(50)

AS
begin
	INSERT INTO dbo.Vehicle (Registration, Miles, Make, Model, Colour)
	VALUES (@Registration, @Miles, @Make, @Model, @Colour);
end
