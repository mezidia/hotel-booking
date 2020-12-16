USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[GetCountry]    Script Date: 16.12.2020 16:59:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCountry]
	-- Add the parameters for the stored procedure here
@CountryID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT [countryName_str]
FROM [dbo].[Countries] WHERE [country_id] = @CountryID
END
