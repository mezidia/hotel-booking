USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[SetRoom]    Script Date: 17.12.2020 15:21:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetUser] 
@PhoneNumber int,
@Email nvarchar(max),
@Login nvarchar(max),
@UserName nvarchar(max),
@Age int,
@Password nvarchar(max),
@Country int,
@Permission int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
INSERT INTO Users(phoneNumber_int, email_str, login_str, userName_str, age_int, password_str, country_id, permission_int) 
VALUES (@PhoneNumber, @Email, @Login, @UserName, @Age, @Password, @Country, @Permission)

END
