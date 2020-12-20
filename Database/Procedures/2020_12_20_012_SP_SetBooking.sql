USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[CancelBooking]    Script Date: 20.12.2020 12:03:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetBooking] 
@Book  int,
 @User int,
 @Room int,
 @Description_str nchar(10),
 @StartDate datetime,
 @EndDate datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Booking] ([book_id], [user_id], [room_id],[description_str], [startDate_int], [endDate_int])
SELECT @Book, @User, @Room, @Description_str, @StartDate, @EndDate

END
