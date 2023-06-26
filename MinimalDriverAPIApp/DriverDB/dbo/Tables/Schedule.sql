CREATE TABLE [dbo].[Schedule]
(
	[ScheduleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StartDateTime] DATETIME NOT NULL, 
    [EndDateTime] DATETIME NOT NULL, 
    [DriverId] INT NOT NULL, 
    [VehicleId] INT NOT NULL, 
    [Priority_Level] INT NOT NULL, 
    CONSTRAINT [FK_Driver] FOREIGN KEY ([DriverId]) REFERENCES [Driver]([DriverId]), 
    CONSTRAINT [FK_Vehicle] FOREIGN KEY (VehicleId) REFERENCES [Vehicle]([VehicleId]) 
)
