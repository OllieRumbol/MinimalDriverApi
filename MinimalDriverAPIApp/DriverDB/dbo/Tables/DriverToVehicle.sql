CREATE TABLE [dbo].[DriverToVehicle]
(
	[DriverToVehicleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DriverId] INT NOT NULL, 
    [VehicleId] INT NOT NULL, 
    CONSTRAINT [FK_DriverToVehile_DriverId] FOREIGN KEY ([DriverId]) REFERENCES [Driver]([DriverId]),
    CONSTRAINT [FK_DriverToVehile_VehicleId] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([VehicleId]) 
)
