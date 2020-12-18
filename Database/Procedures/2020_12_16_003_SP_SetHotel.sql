USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetHotel]    Script Date: 16.12.2020 17:44:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetHotel] 
@Country int,
@Owner int,
@NumberOfStars int,
@Description nvarchar(MAX),
@Location int,
@HotelType int,
@Rating int,
@HotelName nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO Hotels(country_id, owner_id, number_of_stars_int, description_str, location_int, hotelType_int, rating_int, hotelName_str) 
VALUES (@Country, @Owner, @NumberOfStars, @Description, @Location, @HotelType, @Rating, @HotelName)

END
