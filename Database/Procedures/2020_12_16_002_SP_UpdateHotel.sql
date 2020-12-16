USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateHotel]    Script Date: 16.12.2020 17:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateHotel]
@HotelID int,
@Country int,
@Owner int,
@Number_of_stars int,
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
	UPDATE [dbo].[Hotels]
SET [country_id] = @Country,
[owner_id] = @Owner,
[number_of_stars_int] = @Number_of_stars,
[description_str] = @Description,
[location_int] = @Location,
[hotelType_int] = @HotelType,
[rating_int] = @Rating,
[hotelName_str] = @HotelName
WHERE [hotel_id] = @HotelID
END
