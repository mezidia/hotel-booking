USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[LogIn]    Script Date: 07.12.2020 9:33:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CancelBooking] 
@Book  int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
SELECT [book_id], [user_id] 

  FROM [dbo].[Booking] WHERE book_id = @Book
END
