USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFAPassword]    Script Date: 12/19/2019 11:53:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateFAPassword]
	-- Add the parameters for the stored procedure here
	@FA_ID int,
	@password varchar(66)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	Update EFA SET Password = @password where EFAID = @FA_ID 
END
