USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[GetReview]    Script Date: 14.12.2020 12:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRoom]
	-- Add the parameters for the stored procedure here
@RoomID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [hotel_id],
		[price_int],
		[roomNumber_int],
		[TV_bool],
		[roomType_str],
		[numberOfBeds_int],
		[balcony_bool],
		[sale_bool]
FROM [dbo].[Rooms] WHERE [room_id] = @RoomID
END
