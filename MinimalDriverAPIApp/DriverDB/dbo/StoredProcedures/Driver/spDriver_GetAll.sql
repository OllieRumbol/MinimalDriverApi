CREATE PROCEDURE [dbo].[spDriver_GetAll]

AS
begin
	SELECT DriverId, FirstName, LastName, DateOfBirth, DrivingLicenceNumber
	FROM dbo.Driver;
end
