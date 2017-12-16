CREATE PROC Insert_Skill_Info
@SkillId int,
@URL nvarchar(50)

AS

INSERT INTO [dbo].[SkillsInfo] ([dbo].[SkillsInfo].URL,[dbo].[SkillsInfo].Skillid)
VALUES (@URL,@SkillId)

