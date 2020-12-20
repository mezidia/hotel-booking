-- ================================================
-- Template generated from Template Explorer using:
USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetHotel]    Script Date: 20.12.2020 19:16:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetReview] 
@UserID int,
@HotelID int,
@Rating int,
@Review nvarchar(MAX),
@CreationDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO Reviews(user_id, hotel_id, rating_int, review_str, createDate_date) 
VALUES (@UserID, @HotelID, @Rating, @Review, @CreationDate)

END