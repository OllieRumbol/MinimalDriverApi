CREATE PROCEDURE [dbo].[spDriver_Get]
	@Id int
AS
begin
	SELECT DriverId, FirstName, LastName, DateOfBirth, DrivingLicenceNumber
	FROM dbo.Driver
	WHERE DriverId = @id;
end

