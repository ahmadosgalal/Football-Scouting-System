-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE GetPlayerStats_ID 
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select [PID]
      ,[Fname]
      ,[Lname]
      ,ISNULL([Goals],0) as			[Goals]
      ,ISNULL([Assists],0) as		[Assists]
      ,ISNULL([Games_Played],0) as	[Games Played]
      ,ISNULL([Minutes_Played],0) as[Minutes Played]
      ,ISNULL([Chances_Created],0)as[Chances Created]
      ,ISNULL([Match_Rating],0)	as  [Match Rating]
  FROM [Scouting System].[dbo].[Player] where PID=@ID

END
GO
