CREATE TABLE [dbo].[Schedule]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL, 
    [DriverId] INT NOT NULL, 
    [VehicleId] INT NOT NULL, 
    CONSTRAINT [FK_Driver] FOREIGN KEY ([DriverId]) REFERENCES [Driver]([Id]), 
    CONSTRAINT [FK_Vehicle] FOREIGN KEY (VehicleId) REFERENCES [Vehicle]([Id]) 
)
