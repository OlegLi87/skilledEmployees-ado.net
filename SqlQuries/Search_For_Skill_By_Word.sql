USE [SkilledEmployees]
GO
/****** Object:  StoredProcedure [dbo].[Search_For_Skill_By_Word]    Script Date: 10.09.2016 13:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Search_For_Skill_By_Word]
@word nvarchar(50)

AS

SELECT [dbo].[Skills].BriefDescription,[dbo].[Skills].SkillName,[dbo].[SkillsInfo].URL
FROM [dbo].[Skills] JOIN [dbo].[SkillsInfo] ON ([dbo].[Skills].Skillid = [dbo].[SkillsInfo].Skillid)
WHERE [dbo].[Skills].SkillName LIKE @word
