CREATE PROCEDURE [dbo].[spSchedule_Delete]
	@Id int
AS
begin
	DELETE
	FROM dbo.Schedule
	WHERE ScheduleId = @id;
end