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
CREATE PROCEDURE [dbo].[GetBooking] 
@Book  int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT [book_id], [user_id], [room_id],[description_str], [startDate_int], [endDate_int]

  FROM [dbo].[Booking] WHERE book_id = @Book
END
