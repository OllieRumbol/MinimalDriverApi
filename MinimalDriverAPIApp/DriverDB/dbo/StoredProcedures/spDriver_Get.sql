CREATE PROCEDURE [dbo].[spDriver_Get]
	@Id int
AS
begin
	SELECT * 
	FROM dbo.Driver
	WHERE Id = @id;
end

