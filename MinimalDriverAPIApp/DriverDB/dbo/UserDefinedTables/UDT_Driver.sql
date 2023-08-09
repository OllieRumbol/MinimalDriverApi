CREATE TYPE [dbo].UDT_Driver AS TABLE
(
	[DriverId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [DrivingLicenceNumber] NVARCHAR(20) NOT NULL
)
