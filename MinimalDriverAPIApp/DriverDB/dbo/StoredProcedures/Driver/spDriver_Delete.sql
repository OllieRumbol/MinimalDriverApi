﻿CREATE PROCEDURE [dbo].[spDriver_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.Driver
	WHERE DriverId = @id;
end