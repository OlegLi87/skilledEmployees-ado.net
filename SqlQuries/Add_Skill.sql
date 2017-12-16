CREATE PROC Add_Skill
@EmployeeId int,
@SkillName nvarchar(50),
@BriefDescription nvarchar(50)

AS

INSERT INTO [dbo].[Skills] ([dbo].[Skills].SkillName,[dbo].[Skills].BriefDescription,[dbo].[Skills].EmployeeId)
VALUES(@SkillName,@BriefDescription,@EmployeeId)
