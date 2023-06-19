CREATE TABLE [dbo].[Driver]
(
	[DriverId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [DrivingLicenceNumber] NVARCHAR(20) NOT NULL
)
