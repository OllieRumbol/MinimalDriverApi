CREATE PROCEDURE [dbo].[spSchedule_Get]
	@Id int
AS
begin
	SELECT * 
	FROM dbo.Schedule
	WHERE Id = @id;
end

