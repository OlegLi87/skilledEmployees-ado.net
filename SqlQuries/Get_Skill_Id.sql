USE [SkilledEmployees]
GO

DECLARE	@return_value int,
		@SkillId int

EXEC	@return_value = [dbo].[Get_Skill_Id]
		@SkillName = N'CNC',
		@SkillId = @SkillId OUTPUT

SELECT	@SkillId as N'@SkillId'

SELECT	'Return Value' = @return_value

GO
