if not exists (select 1 from dbo.Driver)
begin
	insert into dbo.Driver(FirstName, LastName, DateOfBirth, DrivingLicenceNumber)
	values ('Oliver', 'Bourne', DATEFROMPARTS(1997, 10, 16), '0MSAOT6MUQ2ZZX50'),
	('John', 'Smith', DATEFROMPARTS(1968, 05, 18), 'HE125QI67WD4PND4'),
	('Thomas', 'George', DATEFROMPARTS(1972, 03, 07), 'KRS6VNBJMM4XDDG2'),
	('Ben', 'Tanner', DATEFROMPARTS(1998, 03, 28), 'S8V4CCXH2KEPV2P7');
end

if not exists (select 1 from dbo.Vehicle)
begin
	INSERT INTO dbo.Vehicle (Registration, Miles, Make, Model, Colour)
	values ('AB12 DEF', 2000, 'Ford', 'Transit', 'Blue'), 
	('GH34 IJK', 2002, 'Ford', 'Transit', 'Red'),
	('LM56 NOP', 2004, 'Ford', 'Transit', 'Green')
end

if not exists (select 1 from dbo.Schedule)
begin
	INSERT INTO dbo.Schedule (StartDateTime, EndDateTime, DriverId, VehicleId, Priority_Level)
	values ('2023-06-07 09:00:00', '2023-06-07 11:00:00', 1, 1, 8)
end

if not exists (select 1 from dbo.DriverToVehicle)
begin
	INSERT INTO dbo.DriverToVehicle(DriverId, VehicleId)
	values (1,1),
	(1,2),
	(1,3),
	(3,3)
end