USE [Hotels_DB]
GO

/****** Object:  Table [dbo].[Reviews]    Script Date: 07.12.2020 11:38:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reviews](
	[reviews_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[hotel_id] [int] NOT NULL,
	[rating_int] [int] NOT NULL,
	[review_str] [nvarchar](max) NOT NULL,
	[createDate_date] [int] NOT NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[reviews_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Hotels] FOREIGN KEY([hotel_id])
REFERENCES [dbo].[Hotels] ([hotel_id])
GO

ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Hotels]
GO

ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Users2] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO

ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Users2]
GO


