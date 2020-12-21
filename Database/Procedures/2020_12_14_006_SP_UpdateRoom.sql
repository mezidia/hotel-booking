USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateRooms]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateRooms]
@RoomID int,
@Price int,
@RoomNumber int,
@TV bit,
@RoomType nvarchar(max),
@NumberOfBeds int,
@Balcony bit,
@Sale bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE [dbo].[Rooms]
SET [price_int] = @Price,
[roomNumber_int] = @RoomNumber,
[TV_bool] = @TV,
[roomType_str] = @RoomType,
[numberOfBeds_int] = @NumberOfBeds,
[balcony_bool] = @Balcony,
[sale_bool] = @Sale
WHERE [room_id] = @RoomID
END
