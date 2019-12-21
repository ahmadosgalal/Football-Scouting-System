USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[GetFreeScoutsOffers]    Script Date: 21/12/2019 8:19:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE GetScoutsSignings
	@SID int
AS	
BEGIN
	Select  c.Name as 'Sender club', c.CID as 'Club ID', Fee from OfferScoutC2E o ,Club c where o.ScoutID = @SID and c.CID = o.SenderClubID and Suggestion = 0

	end
