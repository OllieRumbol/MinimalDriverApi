CREATE PROCEDURE [dbo].[spDriver_InsertAll]
	@drivers dbo.UDT_Driver readonly
AS
begin 
	INSERT INTO DBO.Driver (FirstName, LastName, DateOfBirth, DrivingLicenceNumber)
	SELECT FirstName, LastName, DateOfBirth, DrivingLicenceNumber 
	FROM @drivers
end
