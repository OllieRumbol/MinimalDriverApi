CREATE PROCEDURE [dbo].[spDriver_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	UPDATE dbo.Driver
	SET FirstName = @FirstName,  LastName = @LastName
	WHERE Id = @Id
end
