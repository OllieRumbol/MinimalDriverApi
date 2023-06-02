CREATE PROCEDURE [dbo].[spDriver_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.Driver
	WHERE Id = @id;
end