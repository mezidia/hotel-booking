USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetHotel]    Script Date: 20.12.2020 20:01:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RemoveHotel] 
@hotel_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
DELETE FROM [dbo].[Hotels] WHERE [hotel_id] = @hotel_id
END
