USE [Hotels_DB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBooking]    Script Date: 17.12.2020 15:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateUser]
@UserID int,
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
	UPDATE [dbo].[Users]
SET [phoneNumber_int] = @PhoneNumber,
[email_str] = @Email,
[login_str] = @Login,
[userName_str] = @UserName,
[age_int] = @Age,
[password_str] = @Password,
[country_id] = @Country,
[permission_int] = @Permission
WHERE [user_id]= @UserID
END
