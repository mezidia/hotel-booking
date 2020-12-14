USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetRoom]    Script Date: 14.12.2020 12:35:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetRoom] 
@Price int,
@RoomNumber int,
@TV int,
@RoomType nvarchar(max),
@NumberOfBeds int,
@Balcony bit,
@Sale bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO Rooms(price_int, roomNumber_int, TV_bool, roomType_str, numberOfBeds_int, balcony_bool, sale_bool) 
VALUES (@Price, @RoomNumber, @TV, @RoomType, @NumberOfBeds, @Balcony, @Sale)

END
