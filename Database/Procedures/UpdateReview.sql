-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateReview]
	-- Add the parameters for the stored procedure here
	-- Add the parameters for the stored procedure here
@ReviewID int,
@UserID  int,
@Hotel int,
@Rating int,
@Review nvarchar(MAX),
@Date int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
UPDATE [dbo].[Reviews]
SET [user_id] = @UserID,
		[hotel_id] = @Hotel,
		[rating_int] = @Rating,
		[review_str] = @Review,
		[createDate_date] = @Date
WHERE [reviews_id] = @ReviewID
END
GO
