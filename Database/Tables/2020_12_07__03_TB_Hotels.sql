USE [Hotels_DB]
GO

/****** Object:  Table [dbo].[Hotels]    Script Date: 07.12.2020 11:30:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hotels](
	[hotel_id] [int] NOT NULL,
	[country_id] [int] NOT NULL,
	[owner_id] [int] NOT NULL,
	[number_of_stars_int] [int] NOT NULL,
	[description_str] [nvarchar](max) NOT NULL,
	[location_int] [int] NOT NULL,
	[hotelType_int] [int] NOT NULL,
	[rating_int] [int] NOT NULL,
	[hotelName_str] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Hotels_1] PRIMARY KEY CLUSTERED 
(
	[hotel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_Countries] FOREIGN KEY([hotel_id])
REFERENCES [dbo].[Countries] ([country_id])
GO

ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_Countries]
GO

ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_Users] FOREIGN KEY([owner_id])
REFERENCES [dbo].[Users] ([user_id])
GO

ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_Users]
GO


