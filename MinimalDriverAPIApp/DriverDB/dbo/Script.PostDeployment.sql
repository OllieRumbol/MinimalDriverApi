if not exists (select 1 from dbo.Driver)
begin
	insert into dbo.Driver(FirstName, LastName)
	values ('Oliver', 'Bourne'),
	('John', 'Smith'), 
	('Thomas', 'George'),
	('Ben', 'Tanner');
end