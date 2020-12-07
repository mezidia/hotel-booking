USE [Hotels_DB]
GO

/****** Object:  Table [dbo].[Booking]    Script Date: 07.12.2020 11:23:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Booking](
	[book_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[room_id] [int] NOT NULL,
	[description_str] [nchar](10) NOT NULL,
	[startDate_int] [datetime] NOT NULL,
	[endDate_int] [datetime] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Rooms] FOREIGN KEY([room_id])
REFERENCES [dbo].[Rooms] ([room_id])
GO

ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Rooms]
GO

ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO

ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Users]
GO


