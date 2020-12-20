USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetCountry]    Script Date: 16.12.2020 17:13:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetCountry] 
@CountryName nvarchar,
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO Countries(countryName_str) 
VALUES (@CountryName)

END