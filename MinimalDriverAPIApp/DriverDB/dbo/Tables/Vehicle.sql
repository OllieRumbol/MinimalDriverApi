﻿CREATE TABLE [dbo].[Vehicle]
(
	[VehicleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Registration] NVARCHAR(10) NOT NULL, 
    [Miles] INT NOT NULL DEFAULT 0, 
    [Make] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [Colour] NVARCHAR(50) NOT NULL
)
