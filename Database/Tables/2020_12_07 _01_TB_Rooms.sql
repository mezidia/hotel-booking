USE [Hotels_DB]
GO

/****** Object:  Table [dbo].[Rooms]    Script Date: 05.12.2020 10:30:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rooms](
	[room_id] [int] NOT NULL,
	[hotel_id] [int] NOT NULL,
	[price_int] [int] NOT NULL,
	[roomNumber_int] [int] NOT NULL,
	[TV_bool] [bit] NOT NULL,
	[roomType_str] [nvarchar](max) NOT NULL,
	[numberOfBeds_int] [int] NOT NULL,
	[balcony_bool] [bit] NOT NULL,
	[sale_bool] [bit] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


