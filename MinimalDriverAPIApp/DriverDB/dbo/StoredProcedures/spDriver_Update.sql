CREATE PROCEDURE [dbo].[spDriver_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DateOfBirth date,
	@DrivingLicenceNumber nvarchar(20)
AS
begin
	UPDATE dbo.Driver
	SET FirstName = @FirstName,  LastName = @LastName, DateOfBirth = @DateOfBirth, @DrivingLicenceNumber = @DrivingLicenceNumber
	WHERE Id = @Id
end
