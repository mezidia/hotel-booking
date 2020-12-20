USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCountries]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCountries]
@CountryID int,
@CountryName nvarchar,
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE [dbo].[Countries]
SET [countryName_str] = @CountryName
WHERE [country_id] = @CountryID
END
