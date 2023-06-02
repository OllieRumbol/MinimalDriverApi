CREATE PROCEDURE [dbo].[spDriver_GetAll]

AS
begin
	SELECT Id, FirstName, LastName FROM dbo.Driver;
end
