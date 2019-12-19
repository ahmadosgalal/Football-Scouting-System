USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[AddScout]    Script Date: 12/19/2019 11:54:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddScout]
	-- Add the parameters for the stored procedure here
	@SID	int	,
	@Name	varchar(50)	=null,
	@Bdate	date	=null,
	@Endorses	int	=null,
	@password	varchar(66)	=null,
	@ClubID	int	=null,
	@LicenseNumber	int	=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	Insert into Scout values(@SID,@Name,@Bdate,@Endorses,@Password,@ClubID,@LicenseNumber)
END
