CREATE PROCEDURE [dbo].[spSchedule_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.Schedule
	WHERE Id = @id;
end