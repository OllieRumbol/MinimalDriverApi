CREATE PROCEDURE [dbo].[spDriver_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	INSERT INTO dbo.Driver (FirstName, LastName)
	VALUES (@FirstName, @LastName);
end
