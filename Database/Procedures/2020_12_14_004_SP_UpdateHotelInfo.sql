USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateHotelInfo]    Script Date: 14.12.2020 12:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateHotelInfo]
	-- Add the parameters for the stored procedure here
	@HotelID int,
	@NewOwner int,
	@Description nvarchar(max),
	@Location nvarchar(max),
	@HotelType int,
	@HotelName nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here

	UPDATE [dbo].[Hotels]
	SET [owner_id] = @NewOwner,
		[description_str] = @Description,
		[location_int] = @Location,
		[hotelType_int] = @HotelType,
		[hotelName_str] = @HotelName
	WHERE [hotel_id] = @HotelID
END
