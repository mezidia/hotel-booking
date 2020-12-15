USE [Hotels_DB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 07.12.2020 11:38:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[user_id] [int] NOT NULL,
	[country_id] [int] NOT NULL,
	[phoneNumber_int] [int] NOT NULL,
	[email_str] [nvarchar](max) NOT NULL,
	[login_str] [nvarchar](max) NOT NULL,
	[userName_str] [nvarchar](max) NOT NULL,
	[age_int] [int] NOT NULL,
	[password_str] [nvarchar](max) NOT NULL,
	[permission_int] [int] NOT NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Countries] FOREIGN KEY([country_id])
REFERENCES [dbo].[Countries] ([country_id])
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Countries]
GO
