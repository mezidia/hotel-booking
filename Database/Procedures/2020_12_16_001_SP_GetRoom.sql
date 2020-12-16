USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[GetHotel]    Script Date: 16.12.2020 16:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetHotel]
	-- Add the parameters for the stored procedure here
@HotelID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT	[country_id],
		[owner_id],
		[number_of_stars_int],
		[description_str],
		[location_int],
		[hotelType_int],
		[rating_int],
		[hotelName_str]

FROM [dbo].[Hotels] WHERE [hotel_id] = @HotelID
END
