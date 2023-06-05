CREATE PROCEDURE [dbo].[spDriver_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50), 
	@DateOfBirth date,
	@DrivingLicenceNumber nvarchar(20)
AS
begin
	INSERT INTO dbo.Driver (FirstName, LastName, DateOfBirth, DrivingLicenceNumber)
	VALUES (@FirstName, @LastName, @DateOfBirth, @DrivingLicenceNumber);
end
