USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[insertClub]    Script Date: 12/19/2019 11:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[insertClub]
	-- Add the parameters for the stored procedure here
	@CID	int	,
	@Name	varchar(50)	,
	@Abbreviation	varchar(3) 	,
	@City	varchar(50)	= NULL,
	@LeagueName	varchar(50)	= NULL,
	@League_EFAID	int	= NULL,
	@Foundation_Date	date	= NULL,
	@Password	varchar(66)	
AS
BEGIN
INSERT INTO Club(CID,Name,Abbreviation, City, LeagueName, League_EFAID, Foundation_Date, Password)
Values (@CID, @Name, @Abbreviation, @City, @LeagueName, @League_EFAID, @Foundation_Date, @Password)
END
