if not exists (select 1 from dbo.Driver)
begin
	insert into dbo.Driver(FirstName, LastName, DateOfBirth, DrivingLicenceNumber)
	values ('Oliver', 'Bourne', DATEFROMPARTS(1997, 10, 16), '0MSAOT6MUQ2ZZX50'),
	('John', 'Smith', DATEFROMPARTS(1968, 05, 18), 'HE125QI67WD4PND4'),
	('Thomas', 'George', DATEFROMPARTS(1972, 03, 07), 'KRS6VNBJMM4XDDG2'),
	('Ben', 'Tanner', DATEFROMPARTS(1998, 03, 28), 'S8V4CCXH2KEPV2P7');
end